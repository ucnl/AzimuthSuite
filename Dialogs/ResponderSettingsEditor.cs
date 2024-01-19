using AzimuthSuite.AzmCore;
using System;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLUI;
using UCNLUI.Dialogs;

namespace AzimuthSuite.Dialogs
{
    public partial class ResponderSettingsEditor : Form
    {
        #region Properties

        public REMOTE_ADDR_Enum RemoteAddress
        {
            get => (REMOTE_ADDR_Enum)Enum.Parse(typeof(REMOTE_ADDR_Enum), remoteAddressCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(remoteAddressCbx, value.ToString());
        }

        #endregion

        #region Constructor

        public ResponderSettingsEditor()
        {
            InitializeComponent();

            remoteAddressCbx.Items.Clear();
            remoteAddressCbx.Items.AddRange(Enum.GetNames(typeof(REMOTE_ADDR_Enum)));
            remoteAddressCbx.Items.RemoveAt(remoteAddressCbx.Items.Count - 1);

            RemoteAddress = REMOTE_ADDR_Enum.REM_ADDR_1;
        }

        #endregion

        #region Methods


        #endregion

        #region Handlers

        #region UI

        private void applyBtn_Click(object sender, EventArgs e)
        {
            ApplyRequestReceived.Rise(this, e);
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            QueryRequestReceived.Rise(this, e);
        }

        #endregion

        #endregion

        #region Events

        public EventHandler ApplyRequestReceived;
        public EventHandler QueryRequestReceived;

        #endregion
    }
}
