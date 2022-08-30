using System;
using System.Windows.Forms;

namespace AzimuthSuite.Dialogs
{
    public partial class DeviceInfoView : Form
    {
        #region Properties

        public string TextBoxText
        {
            get => txb.Text; 
            set => txb.Text = value;
        }

        #endregion

        public DeviceInfoView()
        {
            InitializeComponent();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            txb.Copy();
        }
    }
}
