namespace AzimuthSuite
{
    partial class SettingsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsEditor));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.isUseAUXGNSSChb = new System.Windows.Forms.CheckBox();
            this.remotesList = new System.Windows.Forms.CheckedListBox();
            this.remotesPanel = new System.Windows.Forms.Panel();
            this.remotesListToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.remotesCheckAllBtn = new System.Windows.Forms.ToolStripButton();
            this.remotesUncheckAllBtn = new System.Windows.Forms.ToolStripButton();
            this.auxGNSSGroup = new System.Windows.Forms.GroupBox();
            this.auxGNSSBaudrateCbx = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.styDialogBtn = new System.Windows.Forms.Button();
            this.styEdit = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxRangeEdit = new System.Windows.Forms.NumericUpDown();
            this.setDaultsBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.xOffsetEdit = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.yOffsetEdit = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.antennaAdjustAngleEdit = new System.Windows.Forms.NumericUpDown();
            this.isUseOutputPortChb = new System.Windows.Forms.CheckBox();
            this.outputPortGroup = new System.Windows.Forms.GroupBox();
            this.outputPortBaudrateCbx = new System.Windows.Forms.ComboBox();
            this.remoteAddressToOutputCbx = new System.Windows.Forms.ComboBox();
            this.remotesPanel.SuspendLayout();
            this.remotesListToolStrip.SuspendLayout();
            this.auxGNSSGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styEdit)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxRangeEdit)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetEdit)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetEdit)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antennaAdjustAngleEdit)).BeginInit();
            this.outputPortGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(644, 513);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 43);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(492, 513);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(124, 43);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // isUseAUXGNSSChb
            // 
            this.isUseAUXGNSSChb.AutoSize = true;
            this.isUseAUXGNSSChb.Location = new System.Drawing.Point(267, 21);
            this.isUseAUXGNSSChb.Name = "isUseAUXGNSSChb";
            this.isUseAUXGNSSChb.Size = new System.Drawing.Size(166, 32);
            this.isUseAUXGNSSChb.TabIndex = 2;
            this.isUseAUXGNSSChb.Text = "Use AUX GNSS";
            this.isUseAUXGNSSChb.UseVisualStyleBackColor = true;
            this.isUseAUXGNSSChb.CheckedChanged += new System.EventHandler(this.isUseAUXGNSSChb_CheckedChanged);
            // 
            // remotesList
            // 
            this.remotesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remotesList.FormattingEnabled = true;
            this.remotesList.IntegralHeight = false;
            this.remotesList.Location = new System.Drawing.Point(3, 30);
            this.remotesList.Name = "remotesList";
            this.remotesList.Size = new System.Drawing.Size(224, 404);
            this.remotesList.TabIndex = 3;
            this.remotesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.remotesList_ItemCheck);
            // 
            // remotesPanel
            // 
            this.remotesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remotesPanel.Controls.Add(this.remotesListToolStrip);
            this.remotesPanel.Controls.Add(this.remotesList);
            this.remotesPanel.Location = new System.Drawing.Point(12, 26);
            this.remotesPanel.Name = "remotesPanel";
            this.remotesPanel.Size = new System.Drawing.Size(230, 437);
            this.remotesPanel.TabIndex = 4;
            // 
            // remotesListToolStrip
            // 
            this.remotesListToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remotesListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.remotesCheckAllBtn,
            this.remotesUncheckAllBtn});
            this.remotesListToolStrip.Location = new System.Drawing.Point(0, 0);
            this.remotesListToolStrip.Name = "remotesListToolStrip";
            this.remotesListToolStrip.Size = new System.Drawing.Size(230, 27);
            this.remotesListToolStrip.TabIndex = 4;
            this.remotesListToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 24);
            this.toolStripLabel1.Text = "REMOTES";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // remotesCheckAllBtn
            // 
            this.remotesCheckAllBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remotesCheckAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.remotesCheckAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("remotesCheckAllBtn.Image")));
            this.remotesCheckAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.remotesCheckAllBtn.Name = "remotesCheckAllBtn";
            this.remotesCheckAllBtn.Size = new System.Drawing.Size(29, 24);
            this.remotesCheckAllBtn.Text = "🗹";
            this.remotesCheckAllBtn.ToolTipText = "Check all";
            this.remotesCheckAllBtn.Click += new System.EventHandler(this.remotesCheckAllBtn_Click);
            // 
            // remotesUncheckAllBtn
            // 
            this.remotesUncheckAllBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remotesUncheckAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.remotesUncheckAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("remotesUncheckAllBtn.Image")));
            this.remotesUncheckAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.remotesUncheckAllBtn.Name = "remotesUncheckAllBtn";
            this.remotesUncheckAllBtn.Size = new System.Drawing.Size(29, 24);
            this.remotesUncheckAllBtn.Text = "☐";
            this.remotesUncheckAllBtn.ToolTipText = "Uncheck all";
            this.remotesUncheckAllBtn.Click += new System.EventHandler(this.remotesUncheckAllBtn_Click);
            // 
            // auxGNSSGroup
            // 
            this.auxGNSSGroup.Controls.Add(this.auxGNSSBaudrateCbx);
            this.auxGNSSGroup.Enabled = false;
            this.auxGNSSGroup.Location = new System.Drawing.Point(267, 56);
            this.auxGNSSGroup.Name = "auxGNSSGroup";
            this.auxGNSSGroup.Size = new System.Drawing.Size(244, 84);
            this.auxGNSSGroup.TabIndex = 5;
            this.auxGNSSGroup.TabStop = false;
            this.auxGNSSGroup.Text = "AUX GNSS Baudrate";
            // 
            // auxGNSSBaudrateCbx
            // 
            this.auxGNSSBaudrateCbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auxGNSSBaudrateCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auxGNSSBaudrateCbx.FormattingEnabled = true;
            this.auxGNSSBaudrateCbx.Location = new System.Drawing.Point(6, 42);
            this.auxGNSSBaudrateCbx.Name = "auxGNSSBaudrateCbx";
            this.auxGNSSBaudrateCbx.Size = new System.Drawing.Size(232, 36);
            this.auxGNSSBaudrateCbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.styDialogBtn);
            this.groupBox2.Controls.Add(this.styEdit);
            this.groupBox2.Location = new System.Drawing.Point(267, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salinity, PSU";
            // 
            // styDialogBtn
            // 
            this.styDialogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.styDialogBtn.Location = new System.Drawing.Point(186, 44);
            this.styDialogBtn.Name = "styDialogBtn";
            this.styDialogBtn.Size = new System.Drawing.Size(52, 34);
            this.styDialogBtn.TabIndex = 1;
            this.styDialogBtn.Text = "🔎";
            this.styDialogBtn.UseVisualStyleBackColor = true;
            this.styDialogBtn.Click += new System.EventHandler(this.styDialogBtn_Click);
            // 
            // styEdit
            // 
            this.styEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.styEdit.DecimalPlaces = 1;
            this.styEdit.Location = new System.Drawing.Point(6, 44);
            this.styEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.styEdit.Name = "styEdit";
            this.styEdit.Size = new System.Drawing.Size(174, 34);
            this.styEdit.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxRangeEdit);
            this.groupBox3.Location = new System.Drawing.Point(267, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 84);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maximal range, m";
            // 
            // maxRangeEdit
            // 
            this.maxRangeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxRangeEdit.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxRangeEdit.Location = new System.Drawing.Point(6, 44);
            this.maxRangeEdit.Maximum = new decimal(new int[] {
            5999,
            0,
            0,
            0});
            this.maxRangeEdit.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxRangeEdit.Name = "maxRangeEdit";
            this.maxRangeEdit.Size = new System.Drawing.Size(174, 34);
            this.maxRangeEdit.TabIndex = 0;
            this.maxRangeEdit.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // setDaultsBtn
            // 
            this.setDaultsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setDaultsBtn.Location = new System.Drawing.Point(12, 513);
            this.setDaultsBtn.Name = "setDaultsBtn";
            this.setDaultsBtn.Size = new System.Drawing.Size(124, 43);
            this.setDaultsBtn.TabIndex = 8;
            this.setDaultsBtn.Text = "DEFAULTS";
            this.setDaultsBtn.UseVisualStyleBackColor = true;
            this.setDaultsBtn.Click += new System.EventHandler(this.setDaultsBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.xOffsetEdit);
            this.groupBox4.Location = new System.Drawing.Point(531, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 84);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Antenna X Offset, m";
            // 
            // xOffsetEdit
            // 
            this.xOffsetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xOffsetEdit.DecimalPlaces = 1;
            this.xOffsetEdit.Location = new System.Drawing.Point(6, 44);
            this.xOffsetEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.xOffsetEdit.Name = "xOffsetEdit";
            this.xOffsetEdit.Size = new System.Drawing.Size(225, 34);
            this.xOffsetEdit.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.yOffsetEdit);
            this.groupBox5.Location = new System.Drawing.Point(531, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 84);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Antenna Y Offset, m";
            // 
            // yOffsetEdit
            // 
            this.yOffsetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yOffsetEdit.DecimalPlaces = 1;
            this.yOffsetEdit.Location = new System.Drawing.Point(6, 44);
            this.yOffsetEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.yOffsetEdit.Name = "yOffsetEdit";
            this.yOffsetEdit.Size = new System.Drawing.Size(225, 34);
            this.yOffsetEdit.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.antennaAdjustAngleEdit);
            this.groupBox6.Location = new System.Drawing.Point(531, 236);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(237, 84);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Antenna angle adjust, °";
            // 
            // antennaAdjustAngleEdit
            // 
            this.antennaAdjustAngleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.antennaAdjustAngleEdit.DecimalPlaces = 1;
            this.antennaAdjustAngleEdit.Location = new System.Drawing.Point(6, 44);
            this.antennaAdjustAngleEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.antennaAdjustAngleEdit.Name = "antennaAdjustAngleEdit";
            this.antennaAdjustAngleEdit.Size = new System.Drawing.Size(225, 34);
            this.antennaAdjustAngleEdit.TabIndex = 1;
            // 
            // isUseOutputPortChb
            // 
            this.isUseOutputPortChb.AutoSize = true;
            this.isUseOutputPortChb.Enabled = false;
            this.isUseOutputPortChb.Location = new System.Drawing.Point(267, 335);
            this.isUseOutputPortChb.Name = "isUseOutputPortChb";
            this.isUseOutputPortChb.Size = new System.Drawing.Size(177, 32);
            this.isUseOutputPortChb.TabIndex = 10;
            this.isUseOutputPortChb.Text = "Use Output port";
            this.isUseOutputPortChb.UseVisualStyleBackColor = true;
            this.isUseOutputPortChb.CheckedChanged += new System.EventHandler(this.isUseOutputPortChb_CheckedChanged);
            // 
            // outputPortGroup
            // 
            this.outputPortGroup.Controls.Add(this.remoteAddressToOutputCbx);
            this.outputPortGroup.Controls.Add(this.outputPortBaudrateCbx);
            this.outputPortGroup.Enabled = false;
            this.outputPortGroup.Location = new System.Drawing.Point(267, 373);
            this.outputPortGroup.Name = "outputPortGroup";
            this.outputPortGroup.Size = new System.Drawing.Size(495, 84);
            this.outputPortGroup.TabIndex = 6;
            this.outputPortGroup.TabStop = false;
            this.outputPortGroup.Text = "Output port Baudrate";
            // 
            // outputPortBaudrateCbx
            // 
            this.outputPortBaudrateCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputPortBaudrateCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputPortBaudrateCbx.FormattingEnabled = true;
            this.outputPortBaudrateCbx.Location = new System.Drawing.Point(6, 42);
            this.outputPortBaudrateCbx.Name = "outputPortBaudrateCbx";
            this.outputPortBaudrateCbx.Size = new System.Drawing.Size(232, 36);
            this.outputPortBaudrateCbx.TabIndex = 0;
            // 
            // remoteAddressToOutputCbx
            // 
            this.remoteAddressToOutputCbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteAddressToOutputCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remoteAddressToOutputCbx.FormattingEnabled = true;
            this.remoteAddressToOutputCbx.Location = new System.Drawing.Point(257, 42);
            this.remoteAddressToOutputCbx.Name = "remoteAddressToOutputCbx";
            this.remoteAddressToOutputCbx.Size = new System.Drawing.Size(232, 36);
            this.remoteAddressToOutputCbx.TabIndex = 1;
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 568);
            this.Controls.Add(this.outputPortGroup);
            this.Controls.Add(this.isUseOutputPortChb);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.setDaultsBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.auxGNSSGroup);
            this.Controls.Add(this.remotesPanel);
            this.Controls.Add(this.isUseAUXGNSSChb);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsEditor";
            this.ShowIcon = false;
            this.Text = "SettingsEditor";
            this.remotesPanel.ResumeLayout(false);
            this.remotesPanel.PerformLayout();
            this.remotesListToolStrip.ResumeLayout(false);
            this.remotesListToolStrip.PerformLayout();
            this.auxGNSSGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styEdit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxRangeEdit)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetEdit)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetEdit)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.antennaAdjustAngleEdit)).EndInit();
            this.outputPortGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.CheckBox isUseAUXGNSSChb;
        private System.Windows.Forms.CheckedListBox remotesList;
        private System.Windows.Forms.Panel remotesPanel;
        private System.Windows.Forms.ToolStrip remotesListToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton remotesCheckAllBtn;
        private System.Windows.Forms.ToolStripButton remotesUncheckAllBtn;
        private System.Windows.Forms.GroupBox auxGNSSGroup;
        private System.Windows.Forms.ComboBox auxGNSSBaudrateCbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown styEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown maxRangeEdit;
        private System.Windows.Forms.Button setDaultsBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown xOffsetEdit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown yOffsetEdit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown antennaAdjustAngleEdit;
        private System.Windows.Forms.Button styDialogBtn;
        private System.Windows.Forms.CheckBox isUseOutputPortChb;
        private System.Windows.Forms.GroupBox outputPortGroup;
        private System.Windows.Forms.ComboBox outputPortBaudrateCbx;
        private System.Windows.Forms.ComboBox remoteAddressToOutputCbx;
    }
}