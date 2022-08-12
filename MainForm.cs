using AzimuthSuit.Dialogs;
using AzimuthSuite.AzmCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLUI;
using UCNLUI.Dialogs;

namespace AzimuthSuite
{
    public partial class MainForm : Form
    {
        #region Properties

        public static readonly string appicon = "🐙";
        bool isRestart = false;

        string logPath;
        string logFileName;
        string settingsFileName;
        string uiSettingsFileName;
        string snapshotsPath;
        string visualStylesPath;

        readonly TSLogProvider logger;
        readonly SimpleSettingsProviderXML<SettingsContainer> sProvider;
        readonly SimpleSettingsProvider<UISettingsContainer> usProvider;
        readonly LogPlayer lPlayer;
        readonly TrackManager trackManager;
        readonly UIAutomation uiAutomation;
        readonly AZMBase azmBase;

        string outPortName
        {
            get => (outputPortCbx.SelectedIndex >= 0) ? outputPortCbx.SelectedItem.ToString() : string.Empty;
            set
            {
                UIHelpers.TrySetCbxItem(outputPortCbx, value);
            }
        }

        REMOTE_ADDR_Enum RemoteAddrToOutput
        {
            get => (REMOTE_ADDR_Enum)Enum.Parse(typeof(REMOTE_ADDR_Enum), remoteAddrToOutportCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(remoteAddrToOutportCbx, value.ToString());
        }

        #region misc. UI things

        bool limboVisible
        {
            get => limboVisibleBtn.Checked;
            set
            {
                limboVisibleBtn.Checked = value;
                usProvider.Data.LimboVisible = value;
                rPlot.LimboVisible = value;
                rPlot.Invalidate();
            }
        }

        bool historyVisible
        {
            get => historyVisibleBtn.Checked;
            set
            {
                historyVisibleBtn.Checked = value;
                usProvider.Data.HistoryVisible = value;
                rPlot.HistoryVisible = value;
                rPlot.Invalidate();
            }
        }

        bool notesVisible
        {
            get => notesVisibleBtn.Checked;
            set
            {
                notesVisibleBtn.Checked = value;
                usProvider.Data.NotesVisible = value;
                rPlot.RightUpperTextVisible = value;
                rPlot.Invalidate();
            }
        }

        bool miscInfoVisible
        {
            get => miscInfoVisibleBtn.Checked;
            set
            {
                miscInfoVisibleBtn.Checked = value;
                usProvider.Data.MiscInfoVisible = value;
                rPlot.LeftUpperTextVisible = value;
                rPlot.Invalidate();
            }
        }


        bool remDistanceAndAzimuthVisible
        {
            get => isDistanceAndAzimuthVisibleBtn.Checked;
            set
            {
                isDistanceAndAzimuthVisibleBtn.Checked = value;
                usProvider.Data.RemDistanceAzimuthVisible = value;
                ///
            }
        }

        bool remDepthVisible
        {
            get => isTreeDepthVisibleBtn.Checked;
            set
            {
                isTreeDepthVisibleBtn.Checked = value;
                usProvider.Data.RemDepthVisible = value;
                ///
            }
        }

        bool remReverseAzimuthVisible
        {
            get => isTreeReverseAzimuthVisibleBtn.Checked;
            set
            {
                isTreeReverseAzimuthVisibleBtn.Checked = value;
                usProvider.Data.RemReverseAzimuthVisible = value;
                ///
            }
        }

        bool remElevationVisible
        {
            get => isTreeElevationVisibleBtn.Checked;
            set
            {
                isTreeElevationVisibleBtn.Checked = value;
                usProvider.Data.RemElevationVisible = value;
                ///
            }
        }

        bool remMiscInfoVisible
        {
            get => isTreeMiscInfoVisibleBtn.Checked;
            set
            {
                isTreeMiscInfoVisibleBtn.Checked = value;
                usProvider.Data.RemMiscInfoVisible = value;
                ///
            }
        }

        bool remLocationVisible
        {
            get => isTreeLocationVisibleBtn.Checked;
            set
            {
                isTreeLocationVisibleBtn.Checked = value;
                usProvider.Data.RemLocationVisible = value;
                ///
            }
        }

        RemoteVisibleDataItems itemsToShow
        {
            get
            {
                RemoteVisibleDataItems result = RemoteVisibleDataItems.none;

                if (remDistanceAndAzimuthVisible)
                    result |= RemoteVisibleDataItems.isDistanceAndAzimuth;
                if (remDepthVisible)
                    result |= RemoteVisibleDataItems.isDepth;
                if (remReverseAzimuthVisible)
                    result |= RemoteVisibleDataItems.isReverseAzimuth;
                if (remElevationVisible)
                    result |= RemoteVisibleDataItems.isElevation;
                if (remMiscInfoVisible)
                    result |= RemoteVisibleDataItems.isMiscInfo;
                if (remLocationVisible)
                    result |= RemoteVisibleDataItems.isLocation;

                return result;
            }
        }

        #endregion

        #region visual styles

        Dictionary<string, VisualStyleContainer> visualStyles;

        #endregion

        #region Misc stuff

        ToolTip tTip;
        IWin32Window tTipWin;

        #endregion

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            #region Early init

            string vString = string.Format("{0} {1} v{2} {3}",
                appicon,
                Application.ProductName,
                Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                MDates.GetReferenceNote());
            this.Text = vString;

            moonPhaseLbl.Text = AstroAndTimeUtils.MoonPhaseIcon(DateTime.Now);
            moonPhaseLbl.ToolTipText = AstroAndTimeUtils.MoonPhaseDescription(DateTime.Now);

            #endregion

            #region paths & filenames

            DateTime startTime = DateTime.Now;
            settingsFileName = Path.ChangeExtension(Application.ExecutablePath, "settings");
            uiSettingsFileName = Path.ChangeExtension(Application.ExecutablePath, "uisettings");
            logPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "LOG");
            logFileName = StrUtils.GetTimeDirTreeFileName(startTime, Application.ExecutablePath, "LOG", "log", true);
            snapshotsPath = StrUtils.GetTimeDirTree(startTime, Application.ExecutablePath, "SNAPSHOTS", false);
            visualStylesPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "VSCS");

            #endregion

            #region logger

            logger = new TSLogProvider(logFileName);
            logger.WriteStart();
            logger.Write(vString);
            logger.TextAddedEvent += (o, e) => InvokeAppendHistoryLine(e.Text);

            #endregion

            #region visual styles

            visualStyles = new Dictionary<string, VisualStyleContainer>();

            AddVisualStyle(new VisualStyleContainer());

            if (Directory.Exists(visualStylesPath))
            {
                var visualStylesNames = Directory.GetFiles(visualStylesPath, "*.vs");
                SimpleSettingsProviderXML<VisualStyleContainer> vsloader = new SimpleSettingsProviderXML<VisualStyleContainer>();

                for (int i = 0; (i < visualStylesNames.Length) && (i < 32); i++)
                {
                    try
                    {
                        vsloader.Load(visualStylesNames[i]);
                        AddVisualStyle(vsloader.Data);
                    }
                    catch (Exception ex)
                    {
                        ProcessException(ex, false);
                    }
                }
            }

            #endregion

            #region settings

            sProvider = new SimpleSettingsProviderXML<SettingsContainer>();
            sProvider.isSwallowExceptions = false;

            logger.Write(string.Format("Loading settings from {0}", settingsFileName));

            try
            {
                sProvider.Load(settingsFileName);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }

            logger.Write("Current application settings:");
            logger.Write(sProvider.Data.ToString());

            #endregion            

            #region trackManager

            trackManager = new TrackManager();
            trackManager.IsEmptyChanged += (o, e) => UIHelpers.InvokeSetEnabledState(mainToolStrip, utilsTrackBtn, !trackManager.IsEmpty);

            #endregion

            #region uiAutomation

            uiAutomation = new UIAutomation();

            uiAutomation.InitBoolProperty<MainForm>(this, nameof(limboVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(historyVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(notesVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(miscInfoVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(remDistanceAndAzimuthVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(remDepthVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(remReverseAzimuthVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(remElevationVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(remMiscInfoVisible));
            uiAutomation.InitBoolProperty<MainForm>(this, nameof(remLocationVisible));

            #endregion

            #region lPlayer

            lPlayer = new LogPlayer();
            lPlayer.NewLogLineHandler += (o, e) =>
            {
                if (e.Line.StartsWith("INFO"))
                {
                    int idx = e.Line.IndexOf(' ');
                    if (idx >= 0)
                    {
                        azmBase.Emulate(e.Line.Substring(idx).Trim());
                    }
                }
                else if (e.Line.StartsWith("NOTE"))
                {
                    var match = Regex.Match(e.Line, "\"[^\" ][^\"]*\"");
                    if (match.Success)
                        InvokeSetNoteText(match.ToString().Trim('"'));
                }
                else if (e.Line.StartsWith(UIAutomation.LogID))
                {
                    int idx = e.Line.IndexOf(' ');
                    if (idx >= 0)
                        InvokePerformUIAction(e.Line.Substring(idx).Trim());
                }
            };
            lPlayer.LogPlaybackFinishedHandler += (o, e) =>
            {
                azmBase.Stop();

                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        settingsBtn.Enabled = true;
                        linkBtn.Enabled = true;
                        logPlaybackBtn.Text = "▶ Playback...";
                        MessageBox.Show(string.Format("Log file \"{0}\" playback is finished", lPlayer.LogFileName), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
                else
                {
                    settingsBtn.Enabled = true;
                    linkBtn.Enabled = true;
                    logPlaybackBtn.Text = "▶ Playback...";
                    MessageBox.Show(string.Format("Log file \"{0}\" playback is finished", lPlayer.LogFileName), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            #endregion

            #region UI settings

            usProvider = new SimpleSettingsProviderXML<UISettingsContainer>();
            usProvider.isSwallowExceptions = true;
            usProvider.Load(uiSettingsFileName);

            limboVisible = usProvider.Data.LimboVisible;
            historyVisible = usProvider.Data.HistoryVisible;
            notesVisible = usProvider.Data.NotesVisible;
            miscInfoVisible = usProvider.Data.MiscInfoVisible;

            remDistanceAndAzimuthVisible = usProvider.Data.RemDistanceAzimuthVisible;
            remDepthVisible = usProvider.Data.RemDepthVisible;
            remReverseAzimuthVisible = usProvider.Data.RemReverseAzimuthVisible;
            remElevationVisible = usProvider.Data.RemElevationVisible;
            remMiscInfoVisible = usProvider.Data.RemMiscInfoVisible;
            remLocationVisible = usProvider.Data.RemLocationVisible;

            if ((usProvider.Data.WSize.Width >= this.MinimumSize.Width) &&
                (usProvider.Data.WSize.Height >= this.MinimumSize.Height))
                this.Size = usProvider.Data.WSize;

            this.Location = usProvider.Data.WLocation;
            this.WindowState = usProvider.Data.WState;

            if (visualStyles.ContainsKey(usProvider.Data.VisualStyle))
                ApplyVisualStyle(usProvider.Data.VisualStyle);
            else
                ApplyVisualStyle(VisualStyleContainer.DefaultName);

            #endregion

            #region azmBase

            azmBase = new AZMBase(sProvider.Data.AddressMask,
                sProvider.Data.Salinity_PSU,
                sProvider.Data.MaxDist_m,
                sProvider.Data.HeadingAdjust_deg,
                sProvider.Data.TransverseOffset_m,
                sProvider.Data.LongitudalOffset_m);

            azmBase.LogEventHandler += (o, e) => logger.Write(string.Format("{0}: {1}", e.EventType, e.LogString));
            azmBase.AbsoluteLocationUpdated += (o, e) =>
                trackManager.AddPoint(e.ID, e.Latitude_deg, e.Longitude_deg, e.Depth_m, DateTime.Now);
            azmBase.RelativeLocationUpdated += (o, e) =>
                InvokeUpdateRelativeLocation(e.ID, e.PRange_m, e.Azimuth_deg);
            azmBase.AZMPortDetectedChanged += (o, e) =>
                InvokeUpdatePortStatusLbl(mainStatusStrip, azmPortStatusLbl, azmBase.IsActive, azmBase.AZMPortDetected, azmBase.AZMPortStatus);
            azmBase.IsActiveChanged += (o, e) =>
            {
                UIHelpers.InvokeSetCheckedState(mainToolStrip, linkBtn, azmBase.IsActive);
                UIHelpers.InvokeSetEnabledState(mainToolStrip, settingsBtn, !azmBase.IsActive);
                UIHelpers.InvokeSetEnabledState(mainToolStrip, logPlaybackBtn, !azmBase.IsActive);
                InvokeUpdatePortStatusLbl(mainStatusStrip, azmPortStatusLbl, azmBase.IsActive, azmBase.AZMPortDetected, azmBase.AZMPortStatus);
                logger.Write(string.Format("{0}={1}", nameof(azmBase.IsActive), azmBase.IsActive));
            };
            azmBase.IsGNSSActiveChanged += (o, e) =>
                InvokeUpdatePortStatusLbl(mainStatusStrip, auxPortStatusLbl, azmBase.IsActive, azmBase.GNSSPortDetected, azmBase.GNSSPortStatus);

            azmBase.GNSSPortDetectedChanged += (o, e) =>
            {
                InvokeUpdatePortStatusLbl(mainStatusStrip, auxPortStatusLbl, azmBase.IsActive, azmBase.GNSSPortDetected, azmBase.GNSSPortStatus);
                InvokeSwitchOutputPortUIEnabledState(azmBase.GNSSPortDetected);

                if (azmBase.GNSSPortDetected &&
                    sProvider.Data.IsUseOutputport &&
                    !azmBase.IsOutPortInitiaziled)
                {
                    // TODO: refactor

                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            outPortsCbxUpdateBtn_Click(null, null);
                            UIHelpers.TrySetCbxItem(outputPortCbx, usProvider.Data.OutPortName);
                            outputPortBtn_Click(null, null);
                        });
                    }
                    else
                    {
                        outPortsCbxUpdateBtn_Click(null, null);
                        UIHelpers.TrySetCbxItem(outputPortCbx, usProvider.Data.OutPortName);
                        outputPortBtn_Click(null, null);
                    }
                }
            };
            azmBase.StateUpdateHandler += (o, e) =>
            {
                InvokeSetPlotLeftUpperText(azmBase.GetMiscInfoDescription());
                InvokeSyncRemotesTree(azmBase.GetRemotesDescription(itemsToShow));
            };
            azmBase.HeadingUpdated += (o, e) => InvokeSetHeading(azmBase.Heading);
            azmBase.DeviceInfoValidChanged += (o, e) =>
            {
                UIHelpers.InvokeSetEnabledState(mainToolStrip, utilsDeviceBtn, azmBase.IsDeviceInfoValid);
                UIHelpers.InvokeSetEnabledState(mainToolStrip, utilsDeviceResponderSettingsBtn, azmBase.IsDeviceInfoValid && (azmBase.DeviceType == AZM_DEVICE_TYPE_Enum.DT_REMOTE));
            };

            if (sProvider.Data.UseAUXGNSSCompas)
            {
                azmBase.AuxGNSSInit(sProvider.Data.AUXGNSSCompasBaudrate);
                auxPortStatusLbl.Visible = true;
            }
            else
            {
                auxPortStatusLbl.Visible = false;
            }

            remoteAddrToOutportCbx.Items.Clear();

            var usedAddresses = AZM.GetAddrsByMask(sProvider.Data.AddressMask);
            foreach (var uAddr in usedAddresses)
                remoteAddrToOutportCbx.Items.Add(uAddr.ToString());

            RemoteAddrToOutput = sProvider.Data.RemoteAddressToOutput;

            SwitchOutputPortUIEnabledState(false);
            SwitchOutputPortUIVisibleState(sProvider.Data.IsUseOutputport);

            #endregion

            #region Misc stuff

            tTip = new ToolTip();
            tTipWin = this;
            tTip.IsBalloon = true;
            tTip.ToolTipIcon = ToolTipIcon.Info;
            tTip.ToolTipTitle = "Hotkeys tip";

            #endregion

            #region Debug

            //azmBase.Demo();

            #endregion
        }

        #endregion

        #region Methods

        private void InvokeSwitchOutputPortUIEnabledState(bool enabled)
        {
            if (mainToolStrip.InvokeRequired)
                mainToolStrip.Invoke((MethodInvoker)delegate { SwitchOutputPortUIEnabledState(enabled); });
            else
                SwitchOutputPortUIEnabledState(enabled);
        }

        private void SwitchOutputPortUIEnabledState(bool enabled)
        {
            outputPortCbx.Enabled = enabled;
            outputPortBtn.Enabled = enabled;
            outPortsCbxUpdateBtn.Enabled = enabled;
            remoteAddrToOutportCbx.Enabled = enabled;
        }

        private void SwitchOutputPortUIVisibleState(bool visible)
        {
            outputPortCbx.Visible = visible;
            outputPortBtn.Visible = visible;
            outPortsCbxUpdateBtn.Visible = visible;
            outportBtnsSeparator.Visible = visible;
            remoteAddrToOutportCbx.Visible = visible;
        }

        #region Custom UI invokers

        private void InvokeSetHeading(double heading_deg)
        {
            if (rPlot.InvokeRequired)
                rPlot.Invoke((MethodInvoker)delegate
                {
                    rPlot.Heading = heading_deg;
                    rPlot.Invalidate();
                });
            else
            {
                rPlot.Heading = heading_deg;
                rPlot.Invalidate();
            }
        }

        private void InvokePerformUIAction(string uiActionName)
        {
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate { uiAutomation.PerformUIAction(uiActionName); });
            else
                uiAutomation.PerformUIAction(uiActionName);
        }

        private void InvokeSetNoteText(string text)
        {
            if (rPlot.InvokeRequired)
                rPlot.Invoke((MethodInvoker)delegate
                {
                    rPlot.RightUpperTextSet(text);
                    rPlot.Invalidate();
                });
            else
            {
                rPlot.RightUpperTextSet(text);
                rPlot.Invalidate();
            }
        }

        private void InvokeAppendHistoryLine(string line)
        {
            if (rPlot.InvokeRequired)
                rPlot.Invoke((MethodInvoker)delegate
                {
                    rPlot.AppendHistoryLine(line);
                    rPlot.Invalidate();
                });
            else
            {
                rPlot.AppendHistoryLine(line);
                rPlot.Invalidate();
            }
        }

        private void InvokeUpdatePortStatusLbl(StatusStrip strip, ToolStripStatusLabel lbl, bool active, bool detected, string text)
        {
            Color backColor = Color.FromKnownColor(KnownColor.Control);
            Color foreColor = Color.FromKnownColor(KnownColor.ControlText);

            if (active)
            {
                foreColor = Color.Yellow;
                if (!detected)
                    backColor = Color.Red;
                else
                    backColor = Color.Green;
            }

            UIHelpers.InvokeSetText(strip, lbl, text, foreColor, backColor);
        }

        private void InvokeUpdateRelativeLocation(string id, double p_range_m, double azimuth_deg)
        {
            if (rPlot.InvokeRequired)
            {
                rPlot.Invoke((MethodInvoker)delegate
                {
                    rPlot.SetTarget(id, p_range_m, azimuth_deg, false);
                    rPlot.Invalidate();
                });
            }
            else
            {
                rPlot.SetTarget(id, p_range_m, azimuth_deg, false);
                rPlot.Invalidate();
            }
        }

        private void InvokeSetPlotLeftUpperText(string text)
        {
            if (rPlot.InvokeRequired)
                rPlot.Invoke((MethodInvoker)delegate
                {
                    rPlot.LeftUpperText = text;
                    rPlot.Invalidate();
                });
            else
            {
                rPlot.LeftUpperText = text;
                rPlot.Invalidate();
            }
        }

        private void SyncRemotesTree(Dictionary<string, Dictionary<string, string>> remotes)
        {
            bool isNeedExpandOnFirst = (remotesTree.Nodes.Count == 0) ||
                ((remotesTree.Nodes.Count > 0) && (remotesTree.Nodes[0].Nodes.Count == 0));

            foreach (var remote in remotes)
            {
                string rKey = remote.Key;
                TreeNode bNode;

                if (!remotesTree.Nodes.ContainsKey(rKey))
                    bNode = remotesTree.Nodes.Add(rKey, rKey);
                else
                    bNode = remotesTree.Nodes[rKey];

                for (int i = bNode.Nodes.Count - 1; i >= 0; i--)
                {
                    if (!remote.Value.ContainsKey(bNode.Nodes[i].Name))
                        bNode.Nodes.RemoveByKey(bNode.Nodes[i].Name);
                }

                foreach (var rItem in remote.Value)
                {
                    if (!bNode.Nodes.ContainsKey(rItem.Key))
                        bNode.Nodes.Add(rItem.Key, string.Format("{0}: {1}", rItem.Key, rItem.Value));
                    else
                        bNode.Nodes[rItem.Key].Text = string.Format("{0}: {1}", rItem.Key, rItem.Value);
                }
            }

            if (isNeedExpandOnFirst)
                remotesTree.ExpandAll();

            remotesTree.Invalidate();
        }

        private void InvokeSyncRemotesTree(Dictionary<string, Dictionary<string, string>> remotes)
        {
            if (remotesTree.InvokeRequired)
                remotesTree.Invoke((MethodInvoker)delegate { SyncRemotesTree(remotes); });
            else
                SyncRemotesTree(remotes);
        }

        #endregion

        private void CheckSpecifiedSubitem(ToolStripDropDownButton btn, string subItemText)
        {
            foreach (var item in btn.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                {
                    ToolStripMenuItem sItem = (item as ToolStripMenuItem);
                    if (sItem.Text != subItemText)
                        sItem.Checked = false;
                    else
                        sItem.Checked = true;
                }
            }
        }

        private void AddVisualStyle(VisualStyleContainer vsc)
        {
            var vsName = vsc.Name;

            if (!visualStyles.ContainsKey(vsName))
            {
                visualStyles.Add(vsName, vsc);

                var newItem = new ToolStripMenuItem(vsName);
                newItem.Click += (o, e) =>
                {
                    ApplyVisualStyle(visualStyles[vsName]);
                };

                paletteBtn.DropDownItems.Add(newItem);
            }
        }

        private void ApplyVisualStyle(string name)
        {
            if (visualStyles.ContainsKey(name))
                ApplyVisualStyle(visualStyles[name]);
        }

        private void ApplyVisualStyle(VisualStyleContainer vsc)
        {
            FontConverter fc = new FontConverter();

            rPlot.BackColor = ColorTranslator.FromHtml(vsc.RPlot_BackColor);
            rPlot.ForeColor = ColorTranslator.FromHtml(vsc.RPlot_ForeColor);
            rPlot.Font = (Font)fc.ConvertFromInvariantString(vsc.RPlot_Font);

            rPlot.AxisBackgroundLabelColor = ColorTranslator.FromHtml(vsc.RPlot_AxisLabelBackgroundColor);
            rPlot.AxisColor = ColorTranslator.FromHtml(vsc.RPlot_AxisColor);
            rPlot.AxisLabelColor = ColorTranslator.FromHtml(vsc.RPlot_AxisLabelColor);
            rPlot.AxisLabelFont = (Font)fc.ConvertFromInvariantString(vsc.RPlot_AxisLabelFont);

            rPlot.BoatColor = ColorTranslator.FromHtml(vsc.RPlot_BoatColor);
            rPlot.BoatSize = vsc.RPlot_BoatSize;

            rPlot.HistoryTextColor = ColorTranslator.FromHtml(vsc.RPlot_HistoryTextColor);
            rPlot.HistoryLinesNumber = vsc.RPlot_HistoryLinesNumber;
            rPlot.HistoryTextFont = (Font)fc.ConvertFromInvariantString(vsc.RPlot_HistoryTextFont);

            rPlot.LeftUpperTextBackgoundColor = ColorTranslator.FromHtml(vsc.RPlot_LeftUpperTextBackgroundColor);
            rPlot.LeftUpperTextColor = ColorTranslator.FromHtml(vsc.RPlot_LeftUpperTextColor);
            rPlot.LeftUpperTextFont = (Font)fc.ConvertFromInvariantString(vsc.RPlot_LeftUpperTextFont);

            rPlot.LimboColor = ColorTranslator.FromHtml(vsc.RPlot_LimboColor);
            rPlot.LimboThickness = vsc.RPlot_LimboThickness;
            rPlot.LimboTickAngleStep = vsc.RPlot_LimboTickAngleStep;
            rPlot.LimboTickCap = vsc.RPlot_LimboTickCap;
            rPlot.LimboTickColor = ColorTranslator.FromHtml(vsc.RPlot_LimboTickColor);
            rPlot.LimboTickThickness = vsc.RPlot_LimboTickThickness;

            rPlot.RightUpperTextBackgoundColor = ColorTranslator.FromHtml(vsc.RPlot_RightUpperTextBackgroundColor);
            rPlot.RightUpperTextColor = ColorTranslator.FromHtml(vsc.RPlot_RightUpperTextColor);
            rPlot.RightUpperTextFont = (Font)fc.ConvertFromInvariantString(vsc.RPlot_RightUpperTextFont);

            rPlot.TargetCircleColor = ColorTranslator.FromHtml(vsc.RPlot_TargetCircleColor);
            rPlot.TargetDistLineColor = ColorTranslator.FromHtml(vsc.RPlot_TargetDistLineColor);
            rPlot.TargetLabelBackgroundColor = ColorTranslator.FromHtml(vsc.RPlot_TargetLabelBackgroundColor);
            rPlot.TargetLabelColor = ColorTranslator.FromHtml(vsc.RPlot_TargetLabelColor);
            rPlot.TargetLabelFont = (Font)fc.ConvertFromInvariantString(vsc.RPlot_TargetLabelFont);

            remotesTree.BackColor = ColorTranslator.FromHtml(vsc.TreeView_BackColor);
            remotesTree.ForeColor = ColorTranslator.FromHtml(vsc.TreeView_ForeColor);
            remotesTree.LineColor = ColorTranslator.FromHtml(vsc.TreeView_LineColor);
            remotesTree.Font = (Font)fc.ConvertFromInvariantString(vsc.TreeView_Font);

            CheckSpecifiedSubitem(paletteBtn, vsc.Name);
            paletteBtn.Text = string.Format("🎨 [{0}]", vsc.Name);

            usProvider.Data.VisualStyle = vsc.Name;
        }

        private void ProcessException(Exception ex, bool isMsgBox)
        {
            logger.Write(ex);

            if (isMsgBox)
                MessageBox.Show(ex.ToString(), string.Format("{0} {1} - Error", appicon, Application.ProductName), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string SaveFullScreenshot()
        {
            Bitmap target = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(target, this.DisplayRectangle);

            try
            {
                if (!Directory.Exists(snapshotsPath))
                    Directory.CreateDirectory(snapshotsPath);

                var fName = string.Format("{0}.{1}", StrUtils.GetHMSString(), ImageFormat.Png);
                var path = Path.Combine(snapshotsPath, fName);
                target.Save(path, ImageFormat.Png);

                return string.Format("Screenshot saved: {0}", fName);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #region Log management

        private int RemoveEmptyEntries(string rootPath, string exclude, int minSize)
        {
            var dirs = Directory.GetDirectories(rootPath);
            int fNum = 0;
            foreach (var item in dirs)
            {
                var fNames = Directory.GetFiles(item);

                foreach (var fName in fNames)
                {
                    if (fName != exclude)
                    {
                        FileInfo fInfo = new FileInfo(fName);
                        if (fInfo.Length <= minSize)
                        {
                            try
                            {
                                File.Delete(fName);
                                fNum++;
                            }
                            catch { }
                        }
                    }
                }

                fNames = Directory.GetFiles(item);
                if (fNames.Length == 0)
                {
                    try
                    {
                        Directory.Delete(item);
                    }
                    catch { }
                }
            }

            return fNum;
        }

        private int ClearAllEntries(string rootPath)
        {
            var dirs = Directory.GetDirectories(rootPath);
            int dirNum = 0;
            foreach (var item in dirs)
            {
                try
                {
                    Directory.Delete(item, true);
                    dirNum++;
                }
                catch (Exception ex)
                {
                    ProcessException(ex, true);
                }
            }

            return dirNum;
        }

        #endregion

        #endregion

        #region Handlers

        #region UI

        #region mainToolStrip

        private void linkBtn_Click(object sender, EventArgs e)
        {
            if (azmBase.IsActive)
                azmBase.Stop();
            else
                azmBase.Start();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            bool isSaved = false;

            using (SettingsEditor sEditor = new SettingsEditor())
            {
                sEditor.Text = string.Format("{0} {1} - Settings", appicon, Application.ProductName);
                sEditor.Value = sProvider.Data;

                if (sEditor.ShowDialog() == DialogResult.OK)
                {
                    sProvider.Data = sEditor.Value;

                    try
                    {
                        sProvider.Save(settingsFileName);
                        isSaved = true;
                    }
                    catch (Exception ex)
                    {
                        ProcessException(ex, true);
                    }
                }
            }

            if (isSaved &&
                MessageBox.Show("Settings has been updated. Restart application to apply new settings?",
                string.Format("{0} {1} - Question", appicon, Application.ProductName),
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                isRestart = true;
                Application.Restart();
            }
        }

        #region LOG

        private void logViewCurrentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(logger.FileName);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void logPlaybackBtn_Click(object sender, EventArgs e)
        {
            if (lPlayer.IsRunning)
            {
                if (MessageBox.Show("Log playback is currently active, do you want to abort it?",
                    string.Format("{0} {1} - Question", appicon, Application.ProductName), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    lPlayer.RequestToStop();
            }
            else
            {
                using (OpenFileDialog oDialog = new OpenFileDialog())
                {
                    oDialog.Title = string.Format("{0} Select a log file to playback...", appicon);
                    oDialog.DefaultExt = "log";
                    oDialog.Filter = "Log files (*.log)|*.log";

                    if (oDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        lPlayer.Playback(oDialog.FileName);

                        logPlaybackBtn.Text = "⏹ Stop playback";
                        settingsBtn.Enabled = false;
                        linkBtn.Enabled = false;
                    }
                }
            }
        }

        private void logCLearEmptyEntriesBtn_Click(object sender, EventArgs e)
        {
            var fNum = RemoveEmptyEntries(logPath, logger.FileName, 2048);

            MessageBox.Show(string.Format("{0} File(s) was/were deleted.", fNum),
                string.Format("{0} {1} - Information", appicon, Application.ProductName),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void logArchiveAllEntriesBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sDialog = new SaveFileDialog())
            {
                sDialog.Title = string.Format("{0} Select a name of acrhive...", appicon);
                sDialog.Filter = "Zip-archives (*.zip)|*.zip";
                sDialog.DefaultExt = "zip";
                sDialog.FileName = string.Format("LOG_Archive_{0}", StrUtils.GetYMDString());

                if (sDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ZipFile.CreateFromDirectory(logPath, sDialog.FileName);
                        logLbl.Text = string.Format("Log directory compressed to {0}", Path.GetFileName(sDialog.FileName));
                    }
                    catch (Exception ex)
                    {
                        ProcessException(ex, true);
                    }
                }
            }
        }

        private void logDeleteAllEntriesBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all log entries? (This action cannot be undone!)",
                                string.Format("{0} {1} - Warning!", appicon, Application.ProductName),

                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {

                var dirNum = ClearAllEntries(logPath);

                MessageBox.Show(string.Format("{0} Entries was/were deleted.", dirNum),
                    string.Format("{0} {1} - Information", appicon, Application.ProductName),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void logDoThemAllBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Move all log entries to an archive? (This action cannot be undone!)",
                               string.Format("{0} {1} - Warning!", appicon, Application.ProductName),
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                RemoveEmptyEntries(logPath, logFileName, 2048);

                bool archived = false;
                using (SaveFileDialog sDialog = new SaveFileDialog())
                {
                    sDialog.Title = string.Format("{0} Select a name of acrhive...", appicon);
                    sDialog.Filter = "Zip-archives (*.zip)|*.zip";
                    sDialog.DefaultExt = "zip";
                    sDialog.FileName = string.Format("LOG_Archive_{0}", StrUtils.GetYMDString());

                    if (sDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            ZipFile.CreateFromDirectory(logPath, sDialog.FileName);
                            logLbl.Text = string.Format("Log directory compressed to {0}", Path.GetFileName(sDialog.FileName));
                            archived = true;
                        }
                        catch (Exception ex)
                        {
                            ProcessException(ex, true);
                        }
                    }
                }

                if (!archived)
                {
                    MessageBox.Show("There were some problems during archive creation, log entries will not be deleted",
                        string.Format("{0} {1} - Error", appicon, Application.ProductName),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    ClearAllEntries(logPath);
                }
            }
        }

        #endregion

        #region UTILS

        private void utilsTracksExportBtn_Click(object sender, EventArgs e)
        {
            bool saved = false;
            using (SaveFileDialog sDialog = new SaveFileDialog())
            {
                sDialog.Title = string.Format("{0} Export tracks to...", appicon);
                sDialog.Filter = "KML (*.kml)|*.kml|CSV (*.csv)|*.csv";
                sDialog.FileName = StrUtils.GetHMSString();

                if (sDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // KML
                        if (sDialog.FilterIndex == 1)
                        {
                            trackManager.ExportToKML(sDialog.FileName);
                            saved = true;
                        }
                        // CSV
                        else if (sDialog.FilterIndex == 2)
                        {
                            trackManager.ExportToCSV(sDialog.FileName);
                            saved = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ProcessException(ex, true);
                    }
                }
            }

            if (saved &&
                (MessageBox.Show("Tracks are saved, clear all tracks data?",
                string.Format("{0} {1} - Question", appicon, Application.ProductName),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes))
                trackManager.Clear();
        }

        private void utilsDeviceViewInfoBtn_Click(object sender, EventArgs e)
        {
            using (DeviceInfoView dDialog = new DeviceInfoView())
            {
                dDialog.Text = string.Format("{0} Device information", appicon);
                dDialog.TextBoxText = string.Format("Device: {0}\r\nSystem: {1}\r\n   S/N: {2}\r\n",
                    azmBase.DeviceType,
                    azmBase.DeviceVersionInfo,
                    azmBase.DeviceSerialNumber);

                dDialog.ShowDialog();
            }
        }

        private void utilsDeviceResponderSettingsBtn_Click(object sender, EventArgs e)
        {
            using (ResponderSettingsEditor rsEditor = new ResponderSettingsEditor())
            {
                rsEditor.Text = string.Format("{0} Responder settings", appicon);
                rsEditor.RemoteAddress = azmBase.DeviceResponderAddress;

                void tHandler(object st, RSTSReceivedEventArgs et)
                {
                    if (rsEditor.InvokeRequired)
                        rsEditor.Invoke((MethodInvoker)delegate
                        {
                            rsEditor.RemoteAddress = et.Addr;
                        });
                    else
                        rsEditor.RemoteAddress = et.Addr;
                };

                azmBase.ResponderSettingsReceived += tHandler;

                rsEditor.ApplyRequestReceived += (o, er) =>
                {
                    if (!azmBase.QueryResponderAddrSet(rsEditor.RemoteAddress))
                        MessageBox.Show(
                            "Request was not sent, try to repeat later.",
                            string.Format("{0} Error", appicon),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                };
                rsEditor.QueryRequestReceived += (o, eq) =>
                {
                    if (!azmBase.QueryResponderAddrGet())
                        MessageBox.Show(
                            "Request was not sent, try to repeat later.",
                            string.Format("{0} Error", appicon),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                };

                rsEditor.ShowDialog();
                azmBase.ResponderSettingsReceived -= tHandler;
            }
        }

        #endregion

        #region Outport

        private void outputPortCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputPortBtn.Enabled = !string.IsNullOrEmpty(outPortName);
        }

        private void outPortsCbxUpdateBtn_Click(object sender, EventArgs e)
        {
            var portsNames = azmBase.GetAvailablePortNames();
            outputPortCbx.Items.Clear();
            outputPortCbx.Items.AddRange(portsNames.ToArray());
            UIHelpers.TrySetCbxItem(outputPortCbx, usProvider.Data.OutPortName);
            if ((outputPortCbx.SelectedIndex < 0) && (outputPortCbx.Items.Count > 0))
                outputPortCbx.SelectedIndex = 0;
        }

        private void outputPortBtn_Click(object sender, EventArgs e)
        {
            if (outputPortBtn.Checked)
            {
                azmBase.DeInitOutputPort();
            }
            else
            {
                try
                {
                    azmBase.RemoteToOutport = RemoteAddrToOutput;
                    azmBase.InitOutputPort(outPortName, sProvider.Data.OutPortBaudrate);
                    logger.Write(string.Format("Initializing outPort on {0}, {1}, Remote Address: {2}",
                        outPortName, sProvider.Data.OutPortBaudrate, RemoteAddrToOutput));
                }
                catch (Exception ex)
                {
                    ProcessException(ex, true);
                }
            }

            outputPortBtn.Checked = azmBase.IsOutPortInitiaziled;
            outPortsCbxUpdateBtn.Enabled = !azmBase.IsOutPortInitiaziled;
            outputPortCbx.Enabled = !azmBase.IsOutPortInitiaziled;

            logger.Write(string.Format("{0}={1}", nameof(azmBase.IsOutPortInitiaziled), azmBase.IsOutPortInitiaziled));
        }

        #endregion

        private void infoBtn_Click(object sender, EventArgs e)
        {
            using (AboutBox aDialog = new AboutBox())
            {
                aDialog.ApplyAssembly(Assembly.GetExecutingAssembly());
                aDialog.Weblink = "www.docs.unavlab.com";
                aDialog.ShowDialog();
            }
        }

        #endregion

        #region rPlotBottomToolStrip

        private void notesTxb_TextChanged(object sender, EventArgs e)
        {
            addNoteBtn.Enabled = !string.IsNullOrWhiteSpace(notesTxb.Text);
        }

        private void notesTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addNoteBtn_Click(null, null);
        }

        private void addNoteBtn_Click(object sender, EventArgs e)
        {
            logger.Write(string.Format("NOTE: \"{0}\"", notesTxb.Text));
            rPlot.RightUpperTextSet(notesTxb.Text);
            notesTxb.Clear();
        }

        private void printScreenBtn_Click(object sender, EventArgs e)
        {
            logLbl.Text = SaveFullScreenshot();
        }

        #endregion

        #region mainForm

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.FinishLog();
            logger.Flush();

            #region UISettings

            usProvider.Data.OutPortName = this.outPortName;
            usProvider.Data.WState = this.WindowState;
            usProvider.Data.WSize = this.Size;
            usProvider.Data.WLocation = this.Location;

            usProvider.Save(uiSettingsFileName);

            #endregion
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trackManager.Changed)
            {
                DialogResult dResult = DialogResult.Yes;
                while (trackManager.Changed && (dResult == DialogResult.Yes))
                {
                    dResult = MessageBox.Show("Tracks are not saved. Do you want to save it before exit?",
                    string.Format("{0} Question", appicon),
                    isRestart ? MessageBoxButtons.YesNo : MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                    if (dResult == DialogResult.Yes)
                        utilsTracksExportBtn_Click(utilsTracksExportBtn, EventArgs.Empty);
                }

                if (dResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
            else
            {
                e.Cancel = !isRestart &&
                    (MessageBox.Show("Close application?",
                    string.Format("{0} {1} - Question", appicon, Application.ProductName),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.P)
                {
                    printScreenBtn_Click(printScreenBtn, null);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.R)
                {
                    if (utilsDeviceResponderSettingsBtn.Enabled)
                        utilsDeviceResponderSettingsBtn_Click(utilsDeviceResponderSettingsBtn, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.S)
                {
                    if (utilsTrackBtn.Enabled)
                        utilsTracksExportBtn_Click(utilsTracksExportBtn, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.L)
                {
                    if (linkBtn.Enabled)
                        linkBtn_Click(linkBtn, null);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.H)
                {
                    logViewCurrentBtn_Click(logViewCurrentBtn, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    treeExpandBtn_Click(treeExpandBtn, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    treeCollapseBtn_Click(treeExpandBtn, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.I)
                {                        
                        tTip.Show(
                            "Ctrl + P           Save screenshot\r\n" +
                            "Ctrl + S           Save tracks\r\n" +
                            "Ctrl + L           Link ON / OFF\r\n" +
                            "Ctrl + H          View current log\r\n" +
                            "Ctrl + Down  Collapse remotes\r\n" +
                            "Ctrl + Up        Expand remotes\r\n" +
                            "Ctrl + R           Resonder settings editor\r\n" +
                            "Ctrl + I            Show this tooltip",
                            tTipWin,
                            new Point(mainSplit.Left, mainSplit.Top),
                            8000);

                    e.SuppressKeyPress = true;
                }
            }

            if (!e.SuppressKeyPress)
            {
                if (!notesTxb.Focused)
                    notesTxb.Focus();
            }
        }

        #endregion

        #region remotesTopStrip

        private void treeExpandBtn_Click(object sender, EventArgs e)
        {
            remotesTree.ExpandAll();
        }

        private void treeCollapseBtn_Click(object sender, EventArgs e)
        {
            remotesTree.CollapseAll();
        }

        #endregion

        #region switch buttons

        private void limboVisibleBtn_Click(object sender, EventArgs e)
        {
            limboVisible = !limboVisible;
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(limboVisible)));
        }

        private void historyVisibleBtn_Click(object sender, EventArgs e)
        {
            historyVisible = !historyVisible;
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(historyVisible)));
        }

        private void notesVisibleBtn_Click(object sender, EventArgs e)
        {
            notesVisible = !notesVisible;
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(notesVisible)));
        }

        private void miscInfoVisibleBtn_Click(object sender, EventArgs e)
        {
            miscInfoVisible = !miscInfoVisible;
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(miscInfoVisible)));
        }

        private void isTreeDistanceAndAzimuthVisibleBtn_Click(object sender, EventArgs e)
        {
            remDistanceAndAzimuthVisible = !remDistanceAndAzimuthVisible;
            SyncRemotesTree(azmBase.GetRemotesDescription(itemsToShow));
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(remDistanceAndAzimuthVisible)));
        }

        private void isTreeDepthVisibleBtn_Click(object sender, EventArgs e)
        {
            remDepthVisible = !remDepthVisible;
            SyncRemotesTree(azmBase.GetRemotesDescription(itemsToShow));
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(remDepthVisible)));
        }

        private void isTreeReverseAzimuthVisibleBtn_Click(object sender, EventArgs e)
        {
            remReverseAzimuthVisible = !remReverseAzimuthVisible;
            SyncRemotesTree(azmBase.GetRemotesDescription(itemsToShow));
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(remReverseAzimuthVisible)));
        }

        private void isTreeElevationVisibleBtn_Click(object sender, EventArgs e)
        {
            remElevationVisible = !remElevationVisible;
            SyncRemotesTree(azmBase.GetRemotesDescription(itemsToShow));
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(remElevationVisible)));
        }

        private void isTreeMiscInfoVisibleBtn_Click(object sender, EventArgs e)
        {
            remMiscInfoVisible = !remMiscInfoVisible;
            SyncRemotesTree(azmBase.GetRemotesDescription(itemsToShow));
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(remMiscInfoVisible)));
        }

        private void isTreeLocationVisibleBtn_Click(object sender, EventArgs e)
        {
            remLocationVisible = !remLocationVisible;
            SyncRemotesTree(azmBase.GetRemotesDescription(itemsToShow));
            logger.Write(uiAutomation.GetBoolPropertyStateLogString<MainForm>(this, nameof(remLocationVisible)));
        }

        #endregion

        #endregion

        #endregion
    }
}
