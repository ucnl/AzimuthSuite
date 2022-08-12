namespace AzimuthSuit.Dialogs
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
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(358, 154);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(124, 43);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // auxGNSSGroup
            // 
            this.auxGNSSGroup.Controls.Add(this.remoteAddressCbx);
            this.auxGNSSGroup.Location = new System.Drawing.Point(12, 20);
            this.auxGNSSGroup.Name = "auxGNSSGroup";
            this.auxGNSSGroup.Size = new System.Drawing.Size(244, 84);
            this.auxGNSSGroup.TabIndex = 9;
            this.auxGNSSGroup.TabStop = false;
            this.auxGNSSGroup.Text = "Responder address";
            // 
            // remoteAddressCbx
            // 
            this.remoteAddressCbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteAddressCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remoteAddressCbx.FormattingEnabled = true;
            this.remoteAddressCbx.Location = new System.Drawing.Point(6, 42);
            this.remoteAddressCbx.Name = "remoteAddressCbx";
            this.remoteAddressCbx.Size = new System.Drawing.Size(232, 36);
            this.remoteAddressCbx.TabIndex = 0;
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.Location = new System.Drawing.Point(358, 61);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(124, 43);
            this.applyBtn.TabIndex = 10;
            this.applyBtn.Text = "📥 APPLY ";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // queryBtn
            // 
            this.queryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryBtn.Location = new System.Drawing.Point(358, 12);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(124, 43);
            this.queryBtn.TabIndex = 11;
            this.queryBtn.Text = "📤 QUERY";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // ResponderSettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 209);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.auxGNSSGroup);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResponderSettingsEditor";
            this.Text = "ResponderSettings";
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