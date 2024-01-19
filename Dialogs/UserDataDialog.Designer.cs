namespace AzimuthSuite.Dialogs
{
    partial class UserDataDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDataDialog));
            this.queryRemoteBtn = new System.Windows.Forms.Button();
            this.writeLocalBtn = new System.Windows.Forms.Button();
            this.responderAddressGroup = new System.Windows.Forms.GroupBox();
            this.remoteAddressCbx = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.userDataIDGroup = new System.Windows.Forms.GroupBox();
            this.userDataIDCbx = new System.Windows.Forms.ComboBox();
            this.readLocalBtn = new System.Windows.Forms.Button();
            this.userDataValueGroup = new System.Windows.Forms.GroupBox();
            this.userDataValueEdit = new System.Windows.Forms.NumericUpDown();
            this.responderAddressGroup.SuspendLayout();
            this.userDataIDGroup.SuspendLayout();
            this.userDataValueGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataValueEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // queryRemoteBtn
            // 
            resources.ApplyResources(this.queryRemoteBtn, "queryRemoteBtn");
            this.queryRemoteBtn.Name = "queryRemoteBtn";
            this.queryRemoteBtn.UseVisualStyleBackColor = true;
            this.queryRemoteBtn.Click += new System.EventHandler(this.queryRemoteBtn_Click);
            // 
            // writeLocalBtn
            // 
            resources.ApplyResources(this.writeLocalBtn, "writeLocalBtn");
            this.writeLocalBtn.Name = "writeLocalBtn";
            this.writeLocalBtn.UseVisualStyleBackColor = true;
            this.writeLocalBtn.Click += new System.EventHandler(this.writeLocalBtn_Click);
            // 
            // responderAddressGroup
            // 
            resources.ApplyResources(this.responderAddressGroup, "responderAddressGroup");
            this.responderAddressGroup.Controls.Add(this.remoteAddressCbx);
            this.responderAddressGroup.Name = "responderAddressGroup";
            this.responderAddressGroup.TabStop = false;
            // 
            // remoteAddressCbx
            // 
            resources.ApplyResources(this.remoteAddressCbx, "remoteAddressCbx");
            this.remoteAddressCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remoteAddressCbx.FormattingEnabled = true;
            this.remoteAddressCbx.Name = "remoteAddressCbx";
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // userDataIDGroup
            // 
            resources.ApplyResources(this.userDataIDGroup, "userDataIDGroup");
            this.userDataIDGroup.Controls.Add(this.userDataIDCbx);
            this.userDataIDGroup.Name = "userDataIDGroup";
            this.userDataIDGroup.TabStop = false;
            // 
            // userDataIDCbx
            // 
            resources.ApplyResources(this.userDataIDCbx, "userDataIDCbx");
            this.userDataIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userDataIDCbx.FormattingEnabled = true;
            this.userDataIDCbx.Name = "userDataIDCbx";
            // 
            // readLocalBtn
            // 
            resources.ApplyResources(this.readLocalBtn, "readLocalBtn");
            this.readLocalBtn.Name = "readLocalBtn";
            this.readLocalBtn.UseVisualStyleBackColor = true;
            this.readLocalBtn.Click += new System.EventHandler(this.readLocalBtn_Click);
            // 
            // userDataValueGroup
            // 
            resources.ApplyResources(this.userDataValueGroup, "userDataValueGroup");
            this.userDataValueGroup.Controls.Add(this.userDataValueEdit);
            this.userDataValueGroup.Name = "userDataValueGroup";
            this.userDataValueGroup.TabStop = false;
            // 
            // userDataValueEdit
            // 
            resources.ApplyResources(this.userDataValueEdit, "userDataValueEdit");
            this.userDataValueEdit.Maximum = new decimal(new int[] {
            499,
            0,
            0,
            0});
            this.userDataValueEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.userDataValueEdit.Name = "userDataValueEdit";
            this.userDataValueEdit.ValueChanged += new System.EventHandler(this.userDataValueEdit_ValueChanged);
            // 
            // UserDataDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userDataValueGroup);
            this.Controls.Add(this.readLocalBtn);
            this.Controls.Add(this.userDataIDGroup);
            this.Controls.Add(this.queryRemoteBtn);
            this.Controls.Add(this.writeLocalBtn);
            this.Controls.Add(this.responderAddressGroup);
            this.Controls.Add(this.closeBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDataDialog";
            this.ShowIcon = false;
            this.responderAddressGroup.ResumeLayout(false);
            this.userDataIDGroup.ResumeLayout(false);
            this.userDataValueGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataValueEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button queryRemoteBtn;
        private System.Windows.Forms.Button writeLocalBtn;
        private System.Windows.Forms.GroupBox responderAddressGroup;
        private System.Windows.Forms.ComboBox remoteAddressCbx;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox userDataIDGroup;
        private System.Windows.Forms.ComboBox userDataIDCbx;
        private System.Windows.Forms.Button readLocalBtn;
        private System.Windows.Forms.GroupBox userDataValueGroup;
        private System.Windows.Forms.NumericUpDown userDataValueEdit;
    }
}