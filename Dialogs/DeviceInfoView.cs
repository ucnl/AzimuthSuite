using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzimuthSuit.Dialogs
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
