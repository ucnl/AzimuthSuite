namespace AzimuthSuite.Dialogs
{
    partial class LocationOverrideDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationOverrideDialog));
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.latDegEdit = new System.Windows.Forms.NumericUpDown();
            this.lonDegEdit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.headingEdit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.latDegEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonDegEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            resources.ApplyResources(this.okBtn, "okBtn");
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Name = "okBtn";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // latDegEdit
            // 
            this.latDegEdit.DecimalPlaces = 6;
            resources.ApplyResources(this.latDegEdit, "latDegEdit");
            this.latDegEdit.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.latDegEdit.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.latDegEdit.Name = "latDegEdit";
            // 
            // lonDegEdit
            // 
            this.lonDegEdit.DecimalPlaces = 6;
            resources.ApplyResources(this.lonDegEdit, "lonDegEdit");
            this.lonDegEdit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.lonDegEdit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.lonDegEdit.Name = "lonDegEdit";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // headingEdit
            // 
            this.headingEdit.DecimalPlaces = 1;
            resources.ApplyResources(this.headingEdit, "headingEdit");
            this.headingEdit.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.headingEdit.Name = "headingEdit";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // LocationOverrideDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headingEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lonDegEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.latDegEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LocationOverrideDialog";
            ((System.ComponentModel.ISupportInitialize)(this.latDegEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonDegEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown latDegEdit;
        private System.Windows.Forms.NumericUpDown lonDegEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown headingEdit;
        private System.Windows.Forms.Label label3;
    }
}