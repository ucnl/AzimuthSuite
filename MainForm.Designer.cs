namespace AzimuthSuite
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.rPlot = new UCNLUI.Controls.RadialPlot();
            this.rPlotBottomStrip = new System.Windows.Forms.ToolStrip();
            this.notesTxb = new System.Windows.Forms.ToolStripTextBox();
            this.addNoteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.printScreenBtn = new System.Windows.Forms.ToolStripButton();
            this.plotToolStrip = new System.Windows.Forms.ToolStrip();
            this.limboVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.historyVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.notesVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.miscInfoVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.paletteBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.remotesTree = new System.Windows.Forms.TreeView();
            this.remotesBottonStrip = new System.Windows.Forms.ToolStrip();
            this.isDistanceAndAzimuthVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.isTreeDepthVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.isTreeReverseAzimuthVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.isTreeElevationVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.isTreeMiscInfoVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.isTreeLocationVisibleBtn = new System.Windows.Forms.ToolStripButton();
            this.remotesTopStrip = new System.Windows.Forms.ToolStrip();
            this.treeExpandBtn = new System.Windows.Forms.ToolStripButton();
            this.treeCollapseBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.azmPortStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacingLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.auxPortStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.logLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.moonPhaseLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.linkBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.logViewCurrentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logPlaybackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.logClearEmptyEntriesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logArchiveAllEntriesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.logDeleteAllEntriesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logDoThemAllBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.utilsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.utilsTrackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsTracksExportBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.utilsDeviceBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsDeviceViewInfoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.utilsDeviceResponderSettingsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsUserDataBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.userDataReadWriteLocalBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.userDataQueryRemoteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.utilsLocationOverrideBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.infoBtn = new System.Windows.Forms.ToolStripButton();
            this.uiTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.remoteAddrToOutportCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.outputPortBtn = new System.Windows.Forms.ToolStripButton();
            this.outputPortCbx = new System.Windows.Forms.ToolStripComboBox();
            this.outPortsCbxUpdateBtn = new System.Windows.Forms.ToolStripButton();
            this.outportBtnsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.udpOutputBtn = new System.Windows.Forms.ToolStripButton();
            this.udpOutputAddrAndPortTxb = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.rPlotBottomStrip.SuspendLayout();
            this.plotToolStrip.SuspendLayout();
            this.remotesBottonStrip.SuspendLayout();
            this.remotesTopStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplit
            // 
            resources.ApplyResources(this.mainSplit, "mainSplit");
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.rPlot);
            this.mainSplit.Panel1.Controls.Add(this.rPlotBottomStrip);
            this.mainSplit.Panel1.Controls.Add(this.plotToolStrip);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.remotesTree);
            this.mainSplit.Panel2.Controls.Add(this.remotesBottonStrip);
            this.mainSplit.Panel2.Controls.Add(this.remotesTopStrip);
            // 
            // rPlot
            // 
            this.rPlot.AxisBackgroundLabelColor = System.Drawing.Color.Black;
            this.rPlot.AxisColor = System.Drawing.Color.LightGray;
            this.rPlot.AxisLabelColor = System.Drawing.Color.LightGray;
            this.rPlot.AxisLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPlot.BackColor = System.Drawing.Color.Black;
            this.rPlot.BoatColor = System.Drawing.Color.Yellow;
            this.rPlot.BoatSize = 16;
            this.rPlot.BoatVisible = true;
            resources.ApplyResources(this.rPlot, "rPlot");
            this.rPlot.Heading = double.NaN;
            this.rPlot.HistoryLinesNumber = 4;
            this.rPlot.HistoryTextColor = System.Drawing.Color.SpringGreen;
            this.rPlot.HistoryTextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPlot.HistoryVisible = true;
            this.rPlot.LeftUpperText = null;
            this.rPlot.LeftUpperTextBackgoundColor = System.Drawing.Color.Transparent;
            this.rPlot.LeftUpperTextColor = System.Drawing.Color.GreenYellow;
            this.rPlot.LeftUpperTextFont = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPlot.LeftUpperTextVisible = true;
            this.rPlot.LimboColor = System.Drawing.Color.LightSeaGreen;
            this.rPlot.LimboThickness = 10;
            this.rPlot.LimboTickAngleStep = 15F;
            this.rPlot.LimboTickCap = System.Drawing.Drawing2D.LineCap.Triangle;
            this.rPlot.LimboTickColor = System.Drawing.Color.LightGray;
            this.rPlot.LimboTickThickness = 10;
            this.rPlot.LimboVisible = true;
            this.rPlot.MaxHistoryLineLength = 127;
            this.rPlot.Name = "rPlot";
            this.rPlot.RightUpperTextBackgoundColor = System.Drawing.Color.Black;
            this.rPlot.RightUpperTextColor = System.Drawing.Color.PowderBlue;
            this.rPlot.RightUpperTextFont = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPlot.RightUpperTextVisible = true;
            this.rPlot.TargetCircleColor = System.Drawing.Color.Goldenrod;
            this.rPlot.TargetDistLineColor = System.Drawing.Color.Gold;
            this.rPlot.TargetLabelBackgroundColor = System.Drawing.Color.Yellow;
            this.rPlot.TargetLabelColor = System.Drawing.Color.Black;
            this.rPlot.TargetLabelFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // rPlotBottomStrip
            // 
            resources.ApplyResources(this.rPlotBottomStrip, "rPlotBottomStrip");
            this.rPlotBottomStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rPlotBottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesTxb,
            this.addNoteBtn,
            this.toolStripSeparator9,
            this.printScreenBtn});
            this.rPlotBottomStrip.Name = "rPlotBottomStrip";
            // 
            // notesTxb
            // 
            resources.ApplyResources(this.notesTxb, "notesTxb");
            this.notesTxb.Name = "notesTxb";
            this.notesTxb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notesTxb_KeyDown);
            this.notesTxb.TextChanged += new System.EventHandler(this.notesTxb_TextChanged);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.addNoteBtn, "addNoteBtn");
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // printScreenBtn
            // 
            this.printScreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.printScreenBtn, "printScreenBtn");
            this.printScreenBtn.Name = "printScreenBtn";
            this.printScreenBtn.Click += new System.EventHandler(this.printScreenBtn_Click);
            // 
            // plotToolStrip
            // 
            resources.ApplyResources(this.plotToolStrip, "plotToolStrip");
            this.plotToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.plotToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limboVisibleBtn,
            this.toolStripSeparator5,
            this.historyVisibleBtn,
            this.toolStripSeparator6,
            this.notesVisibleBtn,
            this.toolStripSeparator7,
            this.miscInfoVisibleBtn,
            this.paletteBtn});
            this.plotToolStrip.Name = "plotToolStrip";
            // 
            // limboVisibleBtn
            // 
            this.limboVisibleBtn.Checked = true;
            this.limboVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.limboVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.limboVisibleBtn, "limboVisibleBtn");
            this.limboVisibleBtn.Name = "limboVisibleBtn";
            this.limboVisibleBtn.Click += new System.EventHandler(this.limboVisibleBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // historyVisibleBtn
            // 
            this.historyVisibleBtn.Checked = true;
            this.historyVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.historyVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.historyVisibleBtn, "historyVisibleBtn");
            this.historyVisibleBtn.Name = "historyVisibleBtn";
            this.historyVisibleBtn.Click += new System.EventHandler(this.historyVisibleBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // notesVisibleBtn
            // 
            this.notesVisibleBtn.Checked = true;
            this.notesVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notesVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.notesVisibleBtn, "notesVisibleBtn");
            this.notesVisibleBtn.Name = "notesVisibleBtn";
            this.notesVisibleBtn.Click += new System.EventHandler(this.notesVisibleBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // miscInfoVisibleBtn
            // 
            this.miscInfoVisibleBtn.Checked = true;
            this.miscInfoVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miscInfoVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.miscInfoVisibleBtn, "miscInfoVisibleBtn");
            this.miscInfoVisibleBtn.Name = "miscInfoVisibleBtn";
            this.miscInfoVisibleBtn.Click += new System.EventHandler(this.miscInfoVisibleBtn_Click);
            // 
            // paletteBtn
            // 
            this.paletteBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.paletteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.paletteBtn, "paletteBtn");
            this.paletteBtn.Name = "paletteBtn";
            // 
            // remotesTree
            // 
            this.remotesTree.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.remotesTree, "remotesTree");
            this.remotesTree.ForeColor = System.Drawing.Color.LawnGreen;
            this.remotesTree.LineColor = System.Drawing.Color.LightGreen;
            this.remotesTree.Name = "remotesTree";
            // 
            // remotesBottonStrip
            // 
            resources.ApplyResources(this.remotesBottonStrip, "remotesBottonStrip");
            this.remotesBottonStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remotesBottonStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isDistanceAndAzimuthVisibleBtn,
            this.isTreeDepthVisibleBtn,
            this.isTreeReverseAzimuthVisibleBtn,
            this.isTreeElevationVisibleBtn,
            this.isTreeMiscInfoVisibleBtn,
            this.isTreeLocationVisibleBtn});
            this.remotesBottonStrip.Name = "remotesBottonStrip";
            // 
            // isDistanceAndAzimuthVisibleBtn
            // 
            this.isDistanceAndAzimuthVisibleBtn.Checked = true;
            this.isDistanceAndAzimuthVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDistanceAndAzimuthVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.isDistanceAndAzimuthVisibleBtn, "isDistanceAndAzimuthVisibleBtn");
            this.isDistanceAndAzimuthVisibleBtn.Name = "isDistanceAndAzimuthVisibleBtn";
            this.isDistanceAndAzimuthVisibleBtn.Click += new System.EventHandler(this.isTreeDistanceAndAzimuthVisibleBtn_Click);
            // 
            // isTreeDepthVisibleBtn
            // 
            this.isTreeDepthVisibleBtn.Checked = true;
            this.isTreeDepthVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isTreeDepthVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.isTreeDepthVisibleBtn, "isTreeDepthVisibleBtn");
            this.isTreeDepthVisibleBtn.Name = "isTreeDepthVisibleBtn";
            this.isTreeDepthVisibleBtn.Click += new System.EventHandler(this.isTreeDepthVisibleBtn_Click);
            // 
            // isTreeReverseAzimuthVisibleBtn
            // 
            this.isTreeReverseAzimuthVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.isTreeReverseAzimuthVisibleBtn, "isTreeReverseAzimuthVisibleBtn");
            this.isTreeReverseAzimuthVisibleBtn.Name = "isTreeReverseAzimuthVisibleBtn";
            this.isTreeReverseAzimuthVisibleBtn.Click += new System.EventHandler(this.isTreeReverseAzimuthVisibleBtn_Click);
            // 
            // isTreeElevationVisibleBtn
            // 
            this.isTreeElevationVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.isTreeElevationVisibleBtn, "isTreeElevationVisibleBtn");
            this.isTreeElevationVisibleBtn.Name = "isTreeElevationVisibleBtn";
            this.isTreeElevationVisibleBtn.Click += new System.EventHandler(this.isTreeElevationVisibleBtn_Click);
            // 
            // isTreeMiscInfoVisibleBtn
            // 
            this.isTreeMiscInfoVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.isTreeMiscInfoVisibleBtn, "isTreeMiscInfoVisibleBtn");
            this.isTreeMiscInfoVisibleBtn.Name = "isTreeMiscInfoVisibleBtn";
            this.isTreeMiscInfoVisibleBtn.Click += new System.EventHandler(this.isTreeMiscInfoVisibleBtn_Click);
            // 
            // isTreeLocationVisibleBtn
            // 
            this.isTreeLocationVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.isTreeLocationVisibleBtn, "isTreeLocationVisibleBtn");
            this.isTreeLocationVisibleBtn.Name = "isTreeLocationVisibleBtn";
            this.isTreeLocationVisibleBtn.Click += new System.EventHandler(this.isTreeLocationVisibleBtn_Click);
            // 
            // remotesTopStrip
            // 
            resources.ApplyResources(this.remotesTopStrip, "remotesTopStrip");
            this.remotesTopStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remotesTopStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeExpandBtn,
            this.treeCollapseBtn,
            this.toolStripLabel1});
            this.remotesTopStrip.Name = "remotesTopStrip";
            // 
            // treeExpandBtn
            // 
            this.treeExpandBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.treeExpandBtn, "treeExpandBtn");
            this.treeExpandBtn.Name = "treeExpandBtn";
            this.treeExpandBtn.Click += new System.EventHandler(this.treeExpandBtn_Click);
            // 
            // treeCollapseBtn
            // 
            this.treeCollapseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.treeCollapseBtn, "treeCollapseBtn");
            this.treeCollapseBtn.Name = "treeCollapseBtn";
            this.treeCollapseBtn.Click += new System.EventHandler(this.treeCollapseBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // mainStatusStrip
            // 
            resources.ApplyResources(this.mainStatusStrip, "mainStatusStrip");
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azmPortStatusLbl,
            this.spacingLbl1,
            this.auxPortStatusLbl,
            this.logLbl,
            this.moonPhaseLbl});
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.ShowItemToolTips = true;
            // 
            // azmPortStatusLbl
            // 
            resources.ApplyResources(this.azmPortStatusLbl, "azmPortStatusLbl");
            this.azmPortStatusLbl.Name = "azmPortStatusLbl";
            // 
            // spacingLbl1
            // 
            this.spacingLbl1.Name = "spacingLbl1";
            resources.ApplyResources(this.spacingLbl1, "spacingLbl1");
            // 
            // auxPortStatusLbl
            // 
            resources.ApplyResources(this.auxPortStatusLbl, "auxPortStatusLbl");
            this.auxPortStatusLbl.Name = "auxPortStatusLbl";
            // 
            // logLbl
            // 
            this.logLbl.Name = "logLbl";
            resources.ApplyResources(this.logLbl, "logLbl");
            this.logLbl.Spring = true;
            // 
            // moonPhaseLbl
            // 
            this.moonPhaseLbl.Name = "moonPhaseLbl";
            resources.ApplyResources(this.moonPhaseLbl, "moonPhaseLbl");
            this.moonPhaseLbl.Click += new System.EventHandler(this.moonPhaseLbl_Click);
            // 
            // mainToolStrip
            // 
            resources.ApplyResources(this.mainToolStrip, "mainToolStrip");
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkBtn,
            this.toolStripSeparator1,
            this.settingsBtn,
            this.toolStripSeparator2,
            this.logBtn,
            this.toolStripSeparator3,
            this.utilsBtn,
            this.toolStripSeparator4,
            this.infoBtn});
            this.mainToolStrip.Name = "mainToolStrip";
            // 
            // linkBtn
            // 
            this.linkBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.linkBtn, "linkBtn");
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.settingsBtn, "settingsBtn");
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // logBtn
            // 
            this.logBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logViewCurrentBtn,
            this.logPlaybackBtn,
            this.toolStripSeparator11,
            this.logClearEmptyEntriesBtn,
            this.logArchiveAllEntriesBtn,
            this.toolStripSeparator12,
            this.logDeleteAllEntriesBtn,
            this.logDoThemAllBtn});
            resources.ApplyResources(this.logBtn, "logBtn");
            this.logBtn.Name = "logBtn";
            // 
            // logViewCurrentBtn
            // 
            resources.ApplyResources(this.logViewCurrentBtn, "logViewCurrentBtn");
            this.logViewCurrentBtn.Name = "logViewCurrentBtn";
            this.logViewCurrentBtn.Click += new System.EventHandler(this.logViewCurrentBtn_Click);
            // 
            // logPlaybackBtn
            // 
            resources.ApplyResources(this.logPlaybackBtn, "logPlaybackBtn");
            this.logPlaybackBtn.Name = "logPlaybackBtn";
            this.logPlaybackBtn.Click += new System.EventHandler(this.logPlaybackBtn_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // logClearEmptyEntriesBtn
            // 
            resources.ApplyResources(this.logClearEmptyEntriesBtn, "logClearEmptyEntriesBtn");
            this.logClearEmptyEntriesBtn.Name = "logClearEmptyEntriesBtn";
            this.logClearEmptyEntriesBtn.Click += new System.EventHandler(this.logCLearEmptyEntriesBtn_Click);
            // 
            // logArchiveAllEntriesBtn
            // 
            resources.ApplyResources(this.logArchiveAllEntriesBtn, "logArchiveAllEntriesBtn");
            this.logArchiveAllEntriesBtn.Name = "logArchiveAllEntriesBtn";
            this.logArchiveAllEntriesBtn.Click += new System.EventHandler(this.logArchiveAllEntriesBtn_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // logDeleteAllEntriesBtn
            // 
            resources.ApplyResources(this.logDeleteAllEntriesBtn, "logDeleteAllEntriesBtn");
            this.logDeleteAllEntriesBtn.Name = "logDeleteAllEntriesBtn";
            this.logDeleteAllEntriesBtn.Click += new System.EventHandler(this.logDeleteAllEntriesBtn_Click);
            // 
            // logDoThemAllBtn
            // 
            resources.ApplyResources(this.logDoThemAllBtn, "logDoThemAllBtn");
            this.logDoThemAllBtn.Name = "logDoThemAllBtn";
            this.logDoThemAllBtn.Click += new System.EventHandler(this.logDoThemAllBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // utilsBtn
            // 
            this.utilsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.utilsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsTrackBtn,
            this.toolStripSeparator8,
            this.utilsDeviceBtn,
            this.toolStripSeparator13,
            this.utilsLocationOverrideBtn});
            resources.ApplyResources(this.utilsBtn, "utilsBtn");
            this.utilsBtn.Name = "utilsBtn";
            // 
            // utilsTrackBtn
            // 
            this.utilsTrackBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsTracksExportBtn});
            resources.ApplyResources(this.utilsTrackBtn, "utilsTrackBtn");
            this.utilsTrackBtn.Name = "utilsTrackBtn";
            // 
            // utilsTracksExportBtn
            // 
            this.utilsTracksExportBtn.Name = "utilsTracksExportBtn";
            resources.ApplyResources(this.utilsTracksExportBtn, "utilsTracksExportBtn");
            this.utilsTracksExportBtn.Click += new System.EventHandler(this.utilsTracksExportBtn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // utilsDeviceBtn
            // 
            this.utilsDeviceBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsDeviceViewInfoBtn,
            this.toolStripSeparator10,
            this.utilsDeviceResponderSettingsBtn,
            this.utilsUserDataBtn});
            resources.ApplyResources(this.utilsDeviceBtn, "utilsDeviceBtn");
            this.utilsDeviceBtn.Name = "utilsDeviceBtn";
            // 
            // utilsDeviceViewInfoBtn
            // 
            resources.ApplyResources(this.utilsDeviceViewInfoBtn, "utilsDeviceViewInfoBtn");
            this.utilsDeviceViewInfoBtn.Name = "utilsDeviceViewInfoBtn";
            this.utilsDeviceViewInfoBtn.Click += new System.EventHandler(this.utilsDeviceViewInfoBtn_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // utilsDeviceResponderSettingsBtn
            // 
            this.utilsDeviceResponderSettingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.utilsDeviceResponderSettingsBtn, "utilsDeviceResponderSettingsBtn");
            this.utilsDeviceResponderSettingsBtn.Name = "utilsDeviceResponderSettingsBtn";
            this.utilsDeviceResponderSettingsBtn.Click += new System.EventHandler(this.utilsDeviceResponderSettingsBtn_Click);
            // 
            // utilsUserDataBtn
            // 
            this.utilsUserDataBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.utilsUserDataBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userDataReadWriteLocalBtn,
            this.userDataQueryRemoteBtn});
            this.utilsUserDataBtn.Name = "utilsUserDataBtn";
            resources.ApplyResources(this.utilsUserDataBtn, "utilsUserDataBtn");
            // 
            // userDataReadWriteLocalBtn
            // 
            resources.ApplyResources(this.userDataReadWriteLocalBtn, "userDataReadWriteLocalBtn");
            this.userDataReadWriteLocalBtn.Name = "userDataReadWriteLocalBtn";
            this.userDataReadWriteLocalBtn.Click += new System.EventHandler(this.userDataReadWriteLocalBtn_Click);
            // 
            // userDataQueryRemoteBtn
            // 
            resources.ApplyResources(this.userDataQueryRemoteBtn, "userDataQueryRemoteBtn");
            this.userDataQueryRemoteBtn.Name = "userDataQueryRemoteBtn";
            this.userDataQueryRemoteBtn.Click += new System.EventHandler(this.userDataQueryRemoteBtn_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            // 
            // utilsLocationOverrideBtn
            // 
            resources.ApplyResources(this.utilsLocationOverrideBtn, "utilsLocationOverrideBtn");
            this.utilsLocationOverrideBtn.Name = "utilsLocationOverrideBtn";
            this.utilsLocationOverrideBtn.Click += new System.EventHandler(this.utilsLocationOverrideBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // infoBtn
            // 
            this.infoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.infoBtn, "infoBtn");
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // uiTimer
            // 
            this.uiTimer.Tick += new System.EventHandler(this.uiTimer_Tick);
            // 
            // bottomToolStrip
            // 
            resources.ApplyResources(this.bottomToolStrip, "bottomToolStrip");
            this.bottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.remoteAddrToOutportCbx,
            this.toolStripSeparator14,
            this.outputPortBtn,
            this.outputPortCbx,
            this.outPortsCbxUpdateBtn,
            this.outportBtnsSeparator,
            this.udpOutputBtn,
            this.udpOutputAddrAndPortTxb,
            this.toolStripSeparator16});
            this.bottomToolStrip.Name = "bottomToolStrip";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // remoteAddrToOutportCbx
            // 
            this.remoteAddrToOutportCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remoteAddrToOutportCbx.DropDownWidth = 200;
            resources.ApplyResources(this.remoteAddrToOutportCbx, "remoteAddrToOutportCbx");
            this.remoteAddrToOutportCbx.Name = "remoteAddrToOutportCbx";
            this.remoteAddrToOutportCbx.SelectedIndexChanged += new System.EventHandler(this.remoteAddrToOutportCbx_SelectedIndexChanged);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            // 
            // outputPortBtn
            // 
            this.outputPortBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.outputPortBtn, "outputPortBtn");
            this.outputPortBtn.Name = "outputPortBtn";
            this.outputPortBtn.Click += new System.EventHandler(this.outputPortBtn_Click);
            // 
            // outputPortCbx
            // 
            this.outputPortCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.outputPortCbx, "outputPortCbx");
            this.outputPortCbx.Name = "outputPortCbx";
            this.outputPortCbx.SelectedIndexChanged += new System.EventHandler(this.outputPortCbx_SelectedIndexChanged);
            // 
            // outPortsCbxUpdateBtn
            // 
            this.outPortsCbxUpdateBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.outPortsCbxUpdateBtn, "outPortsCbxUpdateBtn");
            this.outPortsCbxUpdateBtn.Name = "outPortsCbxUpdateBtn";
            this.outPortsCbxUpdateBtn.Click += new System.EventHandler(this.outPortsCbxUpdateBtn_Click);
            // 
            // outportBtnsSeparator
            // 
            this.outportBtnsSeparator.Name = "outportBtnsSeparator";
            resources.ApplyResources(this.outportBtnsSeparator, "outportBtnsSeparator");
            // 
            // udpOutputBtn
            // 
            this.udpOutputBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.udpOutputBtn, "udpOutputBtn");
            this.udpOutputBtn.Name = "udpOutputBtn";
            this.udpOutputBtn.Click += new System.EventHandler(this.udpOutputBtn_Click);
            // 
            // udpOutputAddrAndPortTxb
            // 
            resources.ApplyResources(this.udpOutputAddrAndPortTxb, "udpOutputAddrAndPortTxb");
            this.udpOutputAddrAndPortTxb.Name = "udpOutputAddrAndPortTxb";
            this.udpOutputAddrAndPortTxb.TextChanged += new System.EventHandler(this.udpOutputTxb_TextChanged);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            resources.ApplyResources(this.toolStripSeparator16, "toolStripSeparator16");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplit);
            this.Controls.Add(this.bottomToolStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel1.PerformLayout();
            this.mainSplit.Panel2.ResumeLayout(false);
            this.mainSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.rPlotBottomStrip.ResumeLayout(false);
            this.rPlotBottomStrip.PerformLayout();
            this.plotToolStrip.ResumeLayout(false);
            this.plotToolStrip.PerformLayout();
            this.remotesBottonStrip.ResumeLayout(false);
            this.remotesBottonStrip.PerformLayout();
            this.remotesTopStrip.ResumeLayout(false);
            this.remotesTopStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.ToolStrip plotToolStrip;
        private System.Windows.Forms.ToolStrip remotesTopStrip;
        private System.Windows.Forms.ToolStripButton linkBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton settingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton infoBtn;
        private System.Windows.Forms.ToolStripButton limboVisibleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton historyVisibleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton notesVisibleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton miscInfoVisibleBtn;
        private System.Windows.Forms.ToolStripDropDownButton paletteBtn;
        private System.Windows.Forms.ToolStrip remotesBottonStrip;
        private System.Windows.Forms.ToolStripButton treeExpandBtn;
        private System.Windows.Forms.ToolStripButton treeCollapseBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TreeView remotesTree;
        private UCNLUI.Controls.RadialPlot rPlot;
        private System.Windows.Forms.ToolStrip rPlotBottomStrip;
        private System.Windows.Forms.ToolStripButton isDistanceAndAzimuthVisibleBtn;
        private System.Windows.Forms.ToolStripButton isTreeDepthVisibleBtn;
        private System.Windows.Forms.ToolStripButton isTreeReverseAzimuthVisibleBtn;
        private System.Windows.Forms.ToolStripButton isTreeElevationVisibleBtn;
        private System.Windows.Forms.ToolStripButton isTreeMiscInfoVisibleBtn;
        private System.Windows.Forms.ToolStripButton isTreeLocationVisibleBtn;
        private System.Windows.Forms.ToolStripDropDownButton logBtn;
        private System.Windows.Forms.ToolStripDropDownButton utilsBtn;
        private System.Windows.Forms.ToolStripMenuItem logViewCurrentBtn;
        private System.Windows.Forms.ToolStripMenuItem logPlaybackBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem logClearEmptyEntriesBtn;
        private System.Windows.Forms.ToolStripMenuItem logArchiveAllEntriesBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem logDeleteAllEntriesBtn;
        private System.Windows.Forms.ToolStripMenuItem logDoThemAllBtn;
        private System.Windows.Forms.ToolStripMenuItem utilsTrackBtn;
        private System.Windows.Forms.ToolStripMenuItem utilsTracksExportBtn;
        private System.Windows.Forms.ToolStripStatusLabel azmPortStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel spacingLbl1;
        private System.Windows.Forms.ToolStripStatusLabel auxPortStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel logLbl;
        private System.Windows.Forms.ToolStripTextBox notesTxb;
        private System.Windows.Forms.ToolStripButton addNoteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton printScreenBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem utilsDeviceBtn;
        private System.Windows.Forms.ToolStripMenuItem utilsDeviceViewInfoBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem utilsDeviceResponderSettingsBtn;
        private System.Windows.Forms.ToolStripStatusLabel moonPhaseLbl;
        private System.Windows.Forms.Timer uiTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem utilsLocationOverrideBtn;
        private System.Windows.Forms.ToolStripMenuItem utilsUserDataBtn;
        private System.Windows.Forms.ToolStripMenuItem userDataReadWriteLocalBtn;
        private System.Windows.Forms.ToolStripMenuItem userDataQueryRemoteBtn;
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox remoteAddrToOutportCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton outputPortBtn;
        private System.Windows.Forms.ToolStripComboBox outputPortCbx;
        private System.Windows.Forms.ToolStripButton outPortsCbxUpdateBtn;
        private System.Windows.Forms.ToolStripSeparator outportBtnsSeparator;
        private System.Windows.Forms.ToolStripButton udpOutputBtn;
        private System.Windows.Forms.ToolStripTextBox udpOutputAddrAndPortTxb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
    }
}

