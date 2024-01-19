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
            this.serialOutputGroup = new System.Windows.Forms.GroupBox();
            this.outputPortBaudrateCbx = new System.Windows.Forms.ComboBox();
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
            this.serialOutputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            resources.ApplyResources(this.okBtn, "okBtn");
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Name = "okBtn";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // isUseAUXGNSSChb
            // 
            resources.ApplyResources(this.isUseAUXGNSSChb, "isUseAUXGNSSChb");
            this.isUseAUXGNSSChb.Name = "isUseAUXGNSSChb";
            this.isUseAUXGNSSChb.UseVisualStyleBackColor = true;
            this.isUseAUXGNSSChb.CheckedChanged += new System.EventHandler(this.isUseAUXGNSSChb_CheckedChanged);
            // 
            // remotesList
            // 
            resources.ApplyResources(this.remotesList, "remotesList");
            this.remotesList.FormattingEnabled = true;
            this.remotesList.Name = "remotesList";
            this.remotesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.remotesList_ItemCheck);
            // 
            // remotesPanel
            // 
            resources.ApplyResources(this.remotesPanel, "remotesPanel");
            this.remotesPanel.Controls.Add(this.remotesListToolStrip);
            this.remotesPanel.Controls.Add(this.remotesList);
            this.remotesPanel.Name = "remotesPanel";
            // 
            // remotesListToolStrip
            // 
            this.remotesListToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remotesListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.remotesCheckAllBtn,
            this.remotesUncheckAllBtn});
            resources.ApplyResources(this.remotesListToolStrip, "remotesListToolStrip");
            this.remotesListToolStrip.Name = "remotesListToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // remotesCheckAllBtn
            // 
            this.remotesCheckAllBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remotesCheckAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.remotesCheckAllBtn, "remotesCheckAllBtn");
            this.remotesCheckAllBtn.Name = "remotesCheckAllBtn";
            this.remotesCheckAllBtn.Click += new System.EventHandler(this.remotesCheckAllBtn_Click);
            // 
            // remotesUncheckAllBtn
            // 
            this.remotesUncheckAllBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remotesUncheckAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.remotesUncheckAllBtn, "remotesUncheckAllBtn");
            this.remotesUncheckAllBtn.Name = "remotesUncheckAllBtn";
            this.remotesUncheckAllBtn.Click += new System.EventHandler(this.remotesUncheckAllBtn_Click);
            // 
            // auxGNSSGroup
            // 
            this.auxGNSSGroup.Controls.Add(this.auxGNSSBaudrateCbx);
            resources.ApplyResources(this.auxGNSSGroup, "auxGNSSGroup");
            this.auxGNSSGroup.Name = "auxGNSSGroup";
            this.auxGNSSGroup.TabStop = false;
            // 
            // auxGNSSBaudrateCbx
            // 
            resources.ApplyResources(this.auxGNSSBaudrateCbx, "auxGNSSBaudrateCbx");
            this.auxGNSSBaudrateCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auxGNSSBaudrateCbx.FormattingEnabled = true;
            this.auxGNSSBaudrateCbx.Name = "auxGNSSBaudrateCbx";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.styDialogBtn);
            this.groupBox2.Controls.Add(this.styEdit);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // styDialogBtn
            // 
            resources.ApplyResources(this.styDialogBtn, "styDialogBtn");
            this.styDialogBtn.Name = "styDialogBtn";
            this.styDialogBtn.UseVisualStyleBackColor = true;
            this.styDialogBtn.Click += new System.EventHandler(this.styDialogBtn_Click);
            // 
            // styEdit
            // 
            resources.ApplyResources(this.styEdit, "styEdit");
            this.styEdit.DecimalPlaces = 1;
            this.styEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.styEdit.Name = "styEdit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxRangeEdit);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // maxRangeEdit
            // 
            resources.ApplyResources(this.maxRangeEdit, "maxRangeEdit");
            this.maxRangeEdit.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
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
            this.maxRangeEdit.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // setDaultsBtn
            // 
            resources.ApplyResources(this.setDaultsBtn, "setDaultsBtn");
            this.setDaultsBtn.Name = "setDaultsBtn";
            this.setDaultsBtn.UseVisualStyleBackColor = true;
            this.setDaultsBtn.Click += new System.EventHandler(this.setDaultsBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.xOffsetEdit);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // xOffsetEdit
            // 
            resources.ApplyResources(this.xOffsetEdit, "xOffsetEdit");
            this.xOffsetEdit.DecimalPlaces = 1;
            this.xOffsetEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.xOffsetEdit.Name = "xOffsetEdit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.yOffsetEdit);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // yOffsetEdit
            // 
            resources.ApplyResources(this.yOffsetEdit, "yOffsetEdit");
            this.yOffsetEdit.DecimalPlaces = 1;
            this.yOffsetEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.yOffsetEdit.Name = "yOffsetEdit";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.antennaAdjustAngleEdit);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // antennaAdjustAngleEdit
            // 
            resources.ApplyResources(this.antennaAdjustAngleEdit, "antennaAdjustAngleEdit");
            this.antennaAdjustAngleEdit.DecimalPlaces = 1;
            this.antennaAdjustAngleEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.antennaAdjustAngleEdit.Name = "antennaAdjustAngleEdit";
            // 
            // serialOutputGroup
            // 
            this.serialOutputGroup.Controls.Add(this.outputPortBaudrateCbx);
            resources.ApplyResources(this.serialOutputGroup, "serialOutputGroup");
            this.serialOutputGroup.Name = "serialOutputGroup";
            this.serialOutputGroup.TabStop = false;
            // 
            // outputPortBaudrateCbx
            // 
            resources.ApplyResources(this.outputPortBaudrateCbx, "outputPortBaudrateCbx");
            this.outputPortBaudrateCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputPortBaudrateCbx.FormattingEnabled = true;
            this.outputPortBaudrateCbx.Name = "outputPortBaudrateCbx";
            // 
            // SettingsEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.serialOutputGroup);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsEditor";
            this.ShowIcon = false;
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
            this.serialOutputGroup.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox serialOutputGroup;
        private System.Windows.Forms.ComboBox outputPortBaudrateCbx;
    }
}