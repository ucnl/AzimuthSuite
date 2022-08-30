namespace AzimuthSuite.Dialogs
{
    partial class ResponderSettingsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponderSettingsEditor));
            this.closeBtn = new System.Windows.Forms.Button();
            this.auxGNSSGroup = new System.Windows.Forms.GroupBox();
            this.remoteAddressCbx = new System.Windows.Forms.ComboBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.queryBtn = new System.Windows.Forms.Button();
            this.auxGNSSGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // auxGNSSGroup
            // 
            resources.ApplyResources(this.auxGNSSGroup, "auxGNSSGroup");
            this.auxGNSSGroup.Controls.Add(this.remoteAddressCbx);
            this.auxGNSSGroup.Name = "auxGNSSGroup";
            this.auxGNSSGroup.TabStop = false;
            // 
            // remoteAddressCbx
            // 
            resources.ApplyResources(this.remoteAddressCbx, "remoteAddressCbx");
            this.remoteAddressCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remoteAddressCbx.FormattingEnabled = true;
            this.remoteAddressCbx.Name = "remoteAddressCbx";
            // 
            // applyBtn
            // 
            resources.ApplyResources(this.applyBtn, "applyBtn");
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // queryBtn
            // 
            resources.ApplyResources(this.queryBtn, "queryBtn");
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // ResponderSettingsEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.auxGNSSGroup);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResponderSettingsEditor";
            this.auxGNSSGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox auxGNSSGroup;
        private System.Windows.Forms.ComboBox remoteAddressCbx;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button queryBtn;
    }
}