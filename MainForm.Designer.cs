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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.azmPortStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacingLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.auxPortStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.logLbl = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.infoBtn = new System.Windows.Forms.ToolStripButton();
            this.outputPortCbx = new System.Windows.Forms.ToolStripComboBox();
            this.outPortsCbxUpdateBtn = new System.Windows.Forms.ToolStripButton();
            this.outputPortBtn = new System.Windows.Forms.ToolStripButton();
            this.remoteAddrToOutportCbx = new System.Windows.Forms.ToolStripComboBox();
            this.outportBtnsSeparator = new System.Windows.Forms.ToolStripSeparator();
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
            this.mainStatusStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.rPlotBottomStrip.SuspendLayout();
            this.plotToolStrip.SuspendLayout();
            this.remotesBottonStrip.SuspendLayout();
            this.remotesTopStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azmPortStatusLbl,
            this.spacingLbl1,
            this.auxPortStatusLbl,
            this.logLbl});
            this.mainStatusStrip.Location = new System.Drawing.Point(3, 684);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1000, 34);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // azmPortStatusLbl
            // 
            this.azmPortStatusLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.azmPortStatusLbl.Name = "azmPortStatusLbl";
            this.azmPortStatusLbl.Size = new System.Drawing.Size(103, 28);
            this.azmPortStatusLbl.Text = "AZM Port";
            this.azmPortStatusLbl.ToolTipText = "AZM device connection status";
            // 
            // spacingLbl1
            // 
            this.spacingLbl1.Name = "spacingLbl1";
            this.spacingLbl1.Size = new System.Drawing.Size(17, 28);
            this.spacingLbl1.Text = " ";
            // 
            // auxPortStatusLbl
            // 
            this.auxPortStatusLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auxPortStatusLbl.Name = "auxPortStatusLbl";
            this.auxPortStatusLbl.Size = new System.Drawing.Size(99, 28);
            this.auxPortStatusLbl.Text = "AUX Port";
            this.auxPortStatusLbl.ToolTipText = "Auxilary GNSS Compass connection status";
            // 
            // logLbl
            // 
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(766, 28);
            this.logLbl.Spring = true;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.infoBtn,
            this.outPortsCbxUpdateBtn,
            this.outputPortCbx,
            this.remoteAddrToOutportCbx,
            this.outputPortBtn,
            this.outportBtnsSeparator});
            this.mainToolStrip.Location = new System.Drawing.Point(3, 3);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1000, 39);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // linkBtn
            // 
            this.linkBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.linkBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkBtn.Image = ((System.Drawing.Image)(resources.GetObject("linkBtn.Image")));
            this.linkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(106, 36);
            this.linkBtn.Text = "🔌 LINK";
            this.linkBtn.ToolTipText = "Ctrl + L to Enable/Disable communication ports";
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(162, 40);
            this.settingsBtn.Text = "⚙ SETTINGS";
            this.settingsBtn.ToolTipText = "Settings editor";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
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
            this.logBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBtn.Image = ((System.Drawing.Image)(resources.GetObject("logBtn.Image")));
            this.logBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(107, 40);
            this.logBtn.Text = "🕮 LOG";
            this.logBtn.ToolTipText = "Log utilities";
            // 
            // logViewCurrentBtn
            // 
            this.logViewCurrentBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logViewCurrentBtn.Name = "logViewCurrentBtn";
            this.logViewCurrentBtn.Size = new System.Drawing.Size(374, 36);
            this.logViewCurrentBtn.Text = "👀 View current";
            this.logViewCurrentBtn.Click += new System.EventHandler(this.logViewCurrentBtn_Click);
            // 
            // logPlaybackBtn
            // 
            this.logPlaybackBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logPlaybackBtn.Name = "logPlaybackBtn";
            this.logPlaybackBtn.Size = new System.Drawing.Size(374, 36);
            this.logPlaybackBtn.Text = "▶ Playback...";
            this.logPlaybackBtn.Click += new System.EventHandler(this.logPlaybackBtn_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(371, 6);
            // 
            // logClearEmptyEntriesBtn
            // 
            this.logClearEmptyEntriesBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logClearEmptyEntriesBtn.Name = "logClearEmptyEntriesBtn";
            this.logClearEmptyEntriesBtn.Size = new System.Drawing.Size(374, 36);
            this.logClearEmptyEntriesBtn.Text = "🧹 Clear empty entries";
            this.logClearEmptyEntriesBtn.Click += new System.EventHandler(this.logDeleteAllEntriesBtn_Click);
            // 
            // logArchiveAllEntriesBtn
            // 
            this.logArchiveAllEntriesBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logArchiveAllEntriesBtn.Name = "logArchiveAllEntriesBtn";
            this.logArchiveAllEntriesBtn.Size = new System.Drawing.Size(374, 36);
            this.logArchiveAllEntriesBtn.Text = "🗜 Archive all entries";
            this.logArchiveAllEntriesBtn.Click += new System.EventHandler(this.logArchiveAllEntriesBtn_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(371, 6);
            // 
            // logDeleteAllEntriesBtn
            // 
            this.logDeleteAllEntriesBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logDeleteAllEntriesBtn.Name = "logDeleteAllEntriesBtn";
            this.logDeleteAllEntriesBtn.Size = new System.Drawing.Size(374, 36);
            this.logDeleteAllEntriesBtn.Text = "🗑 Delete all entries";
            this.logDeleteAllEntriesBtn.Click += new System.EventHandler(this.logDeleteAllEntriesBtn_Click);
            // 
            // logDoThemAllBtn
            // 
            this.logDoThemAllBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logDoThemAllBtn.Name = "logDoThemAllBtn";
            this.logDoThemAllBtn.Size = new System.Drawing.Size(374, 36);
            this.logDoThemAllBtn.Text = "🧹 + 🗜 + 🗑 Do them all";
            this.logDoThemAllBtn.Click += new System.EventHandler(this.logDoThemAllBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // utilsBtn
            // 
            this.utilsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.utilsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsTrackBtn});
            this.utilsBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.utilsBtn.Image = ((System.Drawing.Image)(resources.GetObject("utilsBtn.Image")));
            this.utilsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.utilsBtn.Name = "utilsBtn";
            this.utilsBtn.Size = new System.Drawing.Size(129, 40);
            this.utilsBtn.Text = "🛠 UTILS";
            this.utilsBtn.ToolTipText = "Utilities";
            // 
            // utilsTrackBtn
            // 
            this.utilsTrackBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsTracksExportBtn});
            this.utilsTrackBtn.Enabled = false;
            this.utilsTrackBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.utilsTrackBtn.Name = "utilsTrackBtn";
            this.utilsTrackBtn.Size = new System.Drawing.Size(220, 36);
            this.utilsTrackBtn.Text = "🗺 TRACKS";
            // 
            // utilsTracksExportBtn
            // 
            this.utilsTracksExportBtn.Name = "utilsTracksExportBtn";
            this.utilsTracksExportBtn.Size = new System.Drawing.Size(219, 36);
            this.utilsTracksExportBtn.Text = "💾 Export...";
            this.utilsTracksExportBtn.Click += new System.EventHandler(this.utilsTracksExportBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // infoBtn
            // 
            this.infoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.Image = ((System.Drawing.Image)(resources.GetObject("infoBtn.Image")));
            this.infoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(107, 40);
            this.infoBtn.Text = "ℹ INFO";
            this.infoBtn.ToolTipText = "Infromation about this application & system";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // outputPortCbx
            // 
            this.outputPortCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputPortCbx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputPortCbx.Name = "outputPortCbx";
            this.outputPortCbx.Size = new System.Drawing.Size(121, 43);
            this.outputPortCbx.SelectedIndexChanged += new System.EventHandler(this.outputPortCbx_SelectedIndexChanged);
            // 
            // outPortsCbxUpdateBtn
            // 
            this.outPortsCbxUpdateBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.outPortsCbxUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outPortsCbxUpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("outPortsCbxUpdateBtn.Image")));
            this.outPortsCbxUpdateBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.outPortsCbxUpdateBtn.Name = "outPortsCbxUpdateBtn";
            this.outPortsCbxUpdateBtn.Size = new System.Drawing.Size(51, 40);
            this.outPortsCbxUpdateBtn.Text = "🔄";
            this.outPortsCbxUpdateBtn.ToolTipText = "Refresh list of available ports";
            this.outPortsCbxUpdateBtn.Click += new System.EventHandler(this.outPortsCbxUpdateBtn_Click);
            // 
            // outputPortBtn
            // 
            this.outputPortBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.outputPortBtn.Enabled = false;
            this.outputPortBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputPortBtn.Image = ((System.Drawing.Image)(resources.GetObject("outputPortBtn.Image")));
            this.outputPortBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.outputPortBtn.Name = "outputPortBtn";
            this.outputPortBtn.Size = new System.Drawing.Size(51, 35);
            this.outputPortBtn.Text = "📣";
            this.outputPortBtn.ToolTipText = "Enable/Disable output port";
            this.outputPortBtn.Click += new System.EventHandler(this.outputPortBtn_Click);
            // 
            // remoteAddrToOutportCbx
            // 
            this.remoteAddrToOutportCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remoteAddrToOutportCbx.DropDownWidth = 200;
            this.remoteAddrToOutportCbx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remoteAddrToOutportCbx.Name = "remoteAddrToOutportCbx";
            this.remoteAddrToOutportCbx.Size = new System.Drawing.Size(150, 39);
            this.remoteAddrToOutportCbx.ToolTipText = "Address of the remote to use with output port";
            // 
            // outportBtnsSeparator
            // 
            this.outportBtnsSeparator.Name = "outportBtnsSeparator";
            this.outportBtnsSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(3, 42);
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
            this.mainSplit.Size = new System.Drawing.Size(1000, 642);
            this.mainSplit.SplitterDistance = 635;
            this.mainSplit.TabIndex = 2;
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
            this.rPlot.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.rPlot.Location = new System.Drawing.Point(0, 35);
            this.rPlot.MaxHistoryLineLength = 127;
            this.rPlot.Name = "rPlot";
            this.rPlot.Padding = new System.Windows.Forms.Padding(10);
            this.rPlot.RightUpperTextBackgoundColor = System.Drawing.Color.Black;
            this.rPlot.RightUpperTextColor = System.Drawing.Color.PowderBlue;
            this.rPlot.RightUpperTextFont = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPlot.RightUpperTextVisible = true;
            this.rPlot.Size = new System.Drawing.Size(635, 572);
            this.rPlot.TabIndex = 2;
            this.rPlot.TargetCircleColor = System.Drawing.Color.Goldenrod;
            this.rPlot.TargetDistLineColor = System.Drawing.Color.Gold;
            this.rPlot.TargetLabelBackgroundColor = System.Drawing.Color.Yellow;
            this.rPlot.TargetLabelColor = System.Drawing.Color.Black;
            this.rPlot.TargetLabelFont = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // rPlotBottomStrip
            // 
            this.rPlotBottomStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rPlotBottomStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPlotBottomStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rPlotBottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesTxb,
            this.addNoteBtn,
            this.toolStripSeparator9,
            this.printScreenBtn});
            this.rPlotBottomStrip.Location = new System.Drawing.Point(0, 607);
            this.rPlotBottomStrip.Name = "rPlotBottomStrip";
            this.rPlotBottomStrip.Size = new System.Drawing.Size(635, 35);
            this.rPlotBottomStrip.TabIndex = 1;
            this.rPlotBottomStrip.Text = "toolStrip1";
            // 
            // notesTxb
            // 
            this.notesTxb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notesTxb.MaxLength = 1024;
            this.notesTxb.Name = "notesTxb";
            this.notesTxb.Size = new System.Drawing.Size(250, 35);
            this.notesTxb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notesTxb_KeyDown);
            this.notesTxb.TextChanged += new System.EventHandler(this.notesTxb_TextChanged);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addNoteBtn.Enabled = false;
            this.addNoteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNoteBtn.Image = ((System.Drawing.Image)(resources.GetObject("addNoteBtn.Image")));
            this.addNoteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(147, 32);
            this.addNoteBtn.Text = "📝ADD NOTE";
            this.addNoteBtn.ToolTipText = "Type a note and press \'Enter\'";
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 35);
            // 
            // printScreenBtn
            // 
            this.printScreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.printScreenBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printScreenBtn.Image = ((System.Drawing.Image)(resources.GetObject("printScreenBtn.Image")));
            this.printScreenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printScreenBtn.Name = "printScreenBtn";
            this.printScreenBtn.Size = new System.Drawing.Size(168, 32);
            this.printScreenBtn.Text = "⎙ SCREENSHOT";
            this.printScreenBtn.ToolTipText = "Ctrl + S to save a screenshot";
            this.printScreenBtn.Click += new System.EventHandler(this.printScreenBtn_Click);
            // 
            // plotToolStrip
            // 
            this.plotToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.plotToolStrip.Location = new System.Drawing.Point(0, 0);
            this.plotToolStrip.Name = "plotToolStrip";
            this.plotToolStrip.Size = new System.Drawing.Size(635, 35);
            this.plotToolStrip.TabIndex = 0;
            this.plotToolStrip.Text = "toolStrip1";
            // 
            // limboVisibleBtn
            // 
            this.limboVisibleBtn.Checked = true;
            this.limboVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.limboVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.limboVisibleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limboVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("limboVisibleBtn.Image")));
            this.limboVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limboVisibleBtn.Name = "limboVisibleBtn";
            this.limboVisibleBtn.Size = new System.Drawing.Size(36, 32);
            this.limboVisibleBtn.Text = "⛯";
            this.limboVisibleBtn.Click += new System.EventHandler(this.limboVisibleBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // historyVisibleBtn
            // 
            this.historyVisibleBtn.Checked = true;
            this.historyVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.historyVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyVisibleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyVisibleBtn.Image")));
            this.historyVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyVisibleBtn.Name = "historyVisibleBtn";
            this.historyVisibleBtn.Size = new System.Drawing.Size(43, 32);
            this.historyVisibleBtn.Text = "📜";
            this.historyVisibleBtn.Click += new System.EventHandler(this.historyVisibleBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // notesVisibleBtn
            // 
            this.notesVisibleBtn.Checked = true;
            this.notesVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notesVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.notesVisibleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notesVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("notesVisibleBtn.Image")));
            this.notesVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.notesVisibleBtn.Name = "notesVisibleBtn";
            this.notesVisibleBtn.Size = new System.Drawing.Size(42, 32);
            this.notesVisibleBtn.Text = "📑";
            this.notesVisibleBtn.Click += new System.EventHandler(this.notesVisibleBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // miscInfoVisibleBtn
            // 
            this.miscInfoVisibleBtn.Checked = true;
            this.miscInfoVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miscInfoVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miscInfoVisibleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.miscInfoVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("miscInfoVisibleBtn.Image")));
            this.miscInfoVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miscInfoVisibleBtn.Name = "miscInfoVisibleBtn";
            this.miscInfoVisibleBtn.Size = new System.Drawing.Size(41, 32);
            this.miscInfoVisibleBtn.Text = "👽";
            this.miscInfoVisibleBtn.Click += new System.EventHandler(this.miscInfoVisibleBtn_Click);
            // 
            // paletteBtn
            // 
            this.paletteBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.paletteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.paletteBtn.Image = ((System.Drawing.Image)(resources.GetObject("paletteBtn.Image")));
            this.paletteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paletteBtn.Name = "paletteBtn";
            this.paletteBtn.Size = new System.Drawing.Size(53, 32);
            this.paletteBtn.Text = "🎨";
            this.paletteBtn.ToolTipText = "Color themes";
            // 
            // remotesTree
            // 
            this.remotesTree.BackColor = System.Drawing.Color.Black;
            this.remotesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remotesTree.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remotesTree.ForeColor = System.Drawing.Color.LawnGreen;
            this.remotesTree.LineColor = System.Drawing.Color.LightGreen;
            this.remotesTree.Location = new System.Drawing.Point(0, 35);
            this.remotesTree.Name = "remotesTree";
            this.remotesTree.Size = new System.Drawing.Size(361, 572);
            this.remotesTree.TabIndex = 4;
            // 
            // remotesBottonStrip
            // 
            this.remotesBottonStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.remotesBottonStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remotesBottonStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remotesBottonStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isDistanceAndAzimuthVisibleBtn,
            this.isTreeDepthVisibleBtn,
            this.isTreeReverseAzimuthVisibleBtn,
            this.isTreeElevationVisibleBtn,
            this.isTreeMiscInfoVisibleBtn,
            this.isTreeLocationVisibleBtn});
            this.remotesBottonStrip.Location = new System.Drawing.Point(0, 607);
            this.remotesBottonStrip.Name = "remotesBottonStrip";
            this.remotesBottonStrip.Size = new System.Drawing.Size(361, 35);
            this.remotesBottonStrip.TabIndex = 3;
            this.remotesBottonStrip.Text = "toolStrip1";
            // 
            // isDistanceAndAzimuthVisibleBtn
            // 
            this.isDistanceAndAzimuthVisibleBtn.Checked = true;
            this.isDistanceAndAzimuthVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDistanceAndAzimuthVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isDistanceAndAzimuthVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("isDistanceAndAzimuthVisibleBtn.Image")));
            this.isDistanceAndAzimuthVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isDistanceAndAzimuthVisibleBtn.Name = "isDistanceAndAzimuthVisibleBtn";
            this.isDistanceAndAzimuthVisibleBtn.Size = new System.Drawing.Size(102, 32);
            this.isDistanceAndAzimuthVisibleBtn.Text = "DST/AZM";
            this.isDistanceAndAzimuthVisibleBtn.ToolTipText = "Distance & azimuth visibility switch";
            this.isDistanceAndAzimuthVisibleBtn.Click += new System.EventHandler(this.isTreeDistanceAndAzimuthVisibleBtn_Click);
            // 
            // isTreeDepthVisibleBtn
            // 
            this.isTreeDepthVisibleBtn.Checked = true;
            this.isTreeDepthVisibleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isTreeDepthVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isTreeDepthVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("isTreeDepthVisibleBtn.Image")));
            this.isTreeDepthVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isTreeDepthVisibleBtn.Name = "isTreeDepthVisibleBtn";
            this.isTreeDepthVisibleBtn.Size = new System.Drawing.Size(51, 32);
            this.isTreeDepthVisibleBtn.Text = "DPT";
            this.isTreeDepthVisibleBtn.ToolTipText = "Remote\'s depth visibility switch";
            this.isTreeDepthVisibleBtn.Click += new System.EventHandler(this.isTreeDepthVisibleBtn_Click);
            // 
            // isTreeReverseAzimuthVisibleBtn
            // 
            this.isTreeReverseAzimuthVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isTreeReverseAzimuthVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("isTreeReverseAzimuthVisibleBtn.Image")));
            this.isTreeReverseAzimuthVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isTreeReverseAzimuthVisibleBtn.Name = "isTreeReverseAzimuthVisibleBtn";
            this.isTreeReverseAzimuthVisibleBtn.Size = new System.Drawing.Size(53, 32);
            this.isTreeReverseAzimuthVisibleBtn.Text = "RAZ";
            this.isTreeReverseAzimuthVisibleBtn.ToolTipText = "Reverse azimuth visibility switch";
            this.isTreeReverseAzimuthVisibleBtn.Click += new System.EventHandler(this.isTreeReverseAzimuthVisibleBtn_Click);
            // 
            // isTreeElevationVisibleBtn
            // 
            this.isTreeElevationVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isTreeElevationVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("isTreeElevationVisibleBtn.Image")));
            this.isTreeElevationVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isTreeElevationVisibleBtn.Name = "isTreeElevationVisibleBtn";
            this.isTreeElevationVisibleBtn.Size = new System.Drawing.Size(46, 32);
            this.isTreeElevationVisibleBtn.Text = "ELV";
            this.isTreeElevationVisibleBtn.ToolTipText = "Elevation visibility switch";
            this.isTreeElevationVisibleBtn.Click += new System.EventHandler(this.isTreeElevationVisibleBtn_Click);
            // 
            // isTreeMiscInfoVisibleBtn
            // 
            this.isTreeMiscInfoVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isTreeMiscInfoVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("isTreeMiscInfoVisibleBtn.Image")));
            this.isTreeMiscInfoVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isTreeMiscInfoVisibleBtn.Name = "isTreeMiscInfoVisibleBtn";
            this.isTreeMiscInfoVisibleBtn.Size = new System.Drawing.Size(62, 32);
            this.isTreeMiscInfoVisibleBtn.Text = "MISC";
            this.isTreeMiscInfoVisibleBtn.ToolTipText = "Additional information visibility switch";
            this.isTreeMiscInfoVisibleBtn.Click += new System.EventHandler(this.isTreeMiscInfoVisibleBtn_Click);
            // 
            // isTreeLocationVisibleBtn
            // 
            this.isTreeLocationVisibleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isTreeLocationVisibleBtn.Image = ((System.Drawing.Image)(resources.GetObject("isTreeLocationVisibleBtn.Image")));
            this.isTreeLocationVisibleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isTreeLocationVisibleBtn.Name = "isTreeLocationVisibleBtn";
            this.isTreeLocationVisibleBtn.Size = new System.Drawing.Size(51, 32);
            this.isTreeLocationVisibleBtn.Text = "LOC";
            this.isTreeLocationVisibleBtn.ToolTipText = "Communication quality visibility switch";
            this.isTreeLocationVisibleBtn.Click += new System.EventHandler(this.isTreeLocationVisibleBtn_Click);
            // 
            // remotesTopStrip
            // 
            this.remotesTopStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remotesTopStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remotesTopStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeExpandBtn,
            this.treeCollapseBtn,
            this.toolStripLabel1});
            this.remotesTopStrip.Location = new System.Drawing.Point(0, 0);
            this.remotesTopStrip.Name = "remotesTopStrip";
            this.remotesTopStrip.Size = new System.Drawing.Size(361, 35);
            this.remotesTopStrip.TabIndex = 0;
            this.remotesTopStrip.Text = "toolStrip2";
            // 
            // treeExpandBtn
            // 
            this.treeExpandBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.treeExpandBtn.Image = ((System.Drawing.Image)(resources.GetObject("treeExpandBtn.Image")));
            this.treeExpandBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.treeExpandBtn.Name = "treeExpandBtn";
            this.treeExpandBtn.Size = new System.Drawing.Size(33, 32);
            this.treeExpandBtn.Text = "▲";
            this.treeExpandBtn.ToolTipText = "Expand all";
            this.treeExpandBtn.Click += new System.EventHandler(this.treeExpandBtn_Click);
            // 
            // treeCollapseBtn
            // 
            this.treeCollapseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.treeCollapseBtn.Image = ((System.Drawing.Image)(resources.GetObject("treeCollapseBtn.Image")));
            this.treeCollapseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.treeCollapseBtn.Name = "treeCollapseBtn";
            this.treeCollapseBtn.Size = new System.Drawing.Size(33, 32);
            this.treeCollapseBtn.Text = "▼";
            this.treeCollapseBtn.ToolTipText = "Collapse all";
            this.treeCollapseBtn.Click += new System.EventHandler(this.treeCollapseBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 32);
            this.toolStripLabel1.Text = "REMOTES";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.mainSplit);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowIcon = false;
            this.Text = "🐙 Azimuth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripComboBox outputPortCbx;
        private System.Windows.Forms.ToolStripButton outputPortBtn;
        private System.Windows.Forms.ToolStripSeparator outportBtnsSeparator;
        private System.Windows.Forms.ToolStripButton outPortsCbxUpdateBtn;
        private System.Windows.Forms.ToolStripComboBox remoteAddrToOutportCbx;
    }
}

