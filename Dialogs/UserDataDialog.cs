using AzimuthSuite.AzmCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLUI;

namespace AzimuthSuite.Dialogs
{
    public partial class UserDataDialog : Form
    {
        #region Properties

        public REMOTE_ADDR_Enum RemoteAddress
        {
            get => (REMOTE_ADDR_Enum)Enum.Parse(typeof(REMOTE_ADDR_Enum), remoteAddressCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(remoteAddressCbx, value.ToString());
        }

        public CDS_REQ_CODES_Enum UserDataID
        {
            get => (CDS_REQ_CODES_Enum)Enum.Parse(typeof(CDS_REQ_CODES_Enum), userDataIDCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(userDataIDCbx, value.ToString());
        }

        public int UserDataValue
        {
            get => Convert.ToInt32(userDataValueEdit.Value);
            set => UIHelpers.SetNumericEditValue(userDataValueEdit, value);
        }

        public bool AddressEnabled
        {
            get => responderAddressGroup.Enabled;
            set => responderAddressGroup.Enabled = value;
        }

        public bool UserDataIDEnabled
        {
            get => userDataIDGroup.Enabled;
            set => userDataIDGroup.Enabled = value;
        }

        public bool UserDataValueEnabled
        {
            get => userDataValueGroup.Enabled;
            set => userDataValueGroup.Enabled = value;
        }

        public bool QueryRemoteButtonVisible
        {
            get => queryRemoteBtn.Visible;
            set => queryRemoteBtn.Visible = value;
        }

        public bool ReadLocalButtonVisible
        {
            get => readLocalBtn.Visible;
            set => readLocalBtn.Visible = value; 
        }

        public bool WriteLocalButtonVisible
        {
            get => writeLocalBtn.Visible; 
            set => writeLocalBtn.Visible = value;
        }

        #endregion

        #region Constructor

        public UserDataDialog()
        {
            InitializeComponent();

            remoteAddressCbx.Items.Clear();
            remoteAddressCbx.Items.AddRange(Enum.GetNames(typeof(REMOTE_ADDR_Enum)));
            //remoteAddressCbx.Items.RemoveAt(remoteAddressCbx.Items.Count - 1);

            RemoteAddress = REMOTE_ADDR_Enum.REM_ADDR_1;

            userDataIDCbx.Items.Clear();
            userDataIDCbx.Items.AddRange(
                new string[]
                {
                    "CDS_REQ_USER_CMD_27",
                    "CDS_REQ_USER_CMD_26",
                    "CDS_REQ_USER_CMD_25",
                    "CDS_REQ_USER_CMD_24",
                    "CDS_REQ_USER_CMD_23",
                    "CDS_REQ_USER_CMD_22",
                    "CDS_REQ_USER_CMD_21",
                    "CDS_REQ_USER_CMD_20",
                    "CDS_REQ_USER_CMD_19",
                    "CDS_REQ_USER_CMD_18",
                    "CDS_REQ_USER_CMD_17",
                    "CDS_REQ_USER_CMD_16",
                    "CDS_REQ_USER_CMD_15",
                    "CDS_REQ_USER_CMD_14",
                    "CDS_REQ_USER_CMD_13",
                    "CDS_REQ_USER_CMD_12",
                    "CDS_REQ_USER_CMD_11",
                    "CDS_REQ_USER_CMD_10",
                    "CDS_REQ_USER_CMD_9",
                    "CDS_REQ_USER_CMD_8",
                    "CDS_REQ_USER_CMD_7",
                    "CDS_REQ_USER_CMD_6",
                    "CDS_REQ_USER_CMD_5",
                    "CDS_REQ_USER_CMD_4",
                    "CDS_REQ_USER_CMD_3",
                    "CDS_REQ_USER_CMD_2",
                    "CDS_REQ_USER_CMD_1",
                    "CDS_REQ_USER_CMD_0",
                });

            UserDataID = CDS_REQ_CODES_Enum.CDS_REQ_USER_CMD_0;
        }

        #endregion

        #region Handlers

        #region UI

        private void queryRemoteBtn_Click(object sender, EventArgs e)
        {
            QueryRemoteRequestReceived.Rise(this, e);
        }

        private void readLocalBtn_Click(object sender, EventArgs e)
        {
            ReadLocalRequestReceived.Rise(this, e);
        }

        private void writeLocalBtn_Click(object sender, EventArgs e)
        {
            WriteLocalRequestReceived.Rise(this, e);
        }

        #endregion

        #endregion

        #region Events

        public EventHandler ReadLocalRequestReceived;
        public EventHandler WriteLocalRequestReceived;
        public EventHandler QueryRemoteRequestReceived;

        #endregion

        private void userDataValueEdit_ValueChanged(object sender, EventArgs e)
        {
            writeLocalBtn.Enabled = UserDataValue >= 0;
        }
    }
}
