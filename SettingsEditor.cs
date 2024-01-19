﻿using AzimuthSuite.AzmCore;
using System;
using System.Net;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLUI;
using UCNLUI.Dialogs;

namespace AzimuthSuite
{
    public partial class SettingsEditor : Form
    {
        #region Properties

        ushort addrMask
        {
            get
            {
                ushort result = 0;

                for (int i = 0; i < 16; i++)
                {
                    if (remotesList.GetItemCheckState(i) == CheckState.Checked)
                    {
                        result |= (ushort)(1 << i);
                    }
                }

                return result;
            }
            set
            {
                for (int i = 0; i < 16; i++)
                {
                    if ((value & (ushort)(1 << i)) != 0)
                        remotesList.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        bool isUseAUXGNSS
        {
            get => isUseAUXGNSSChb.Checked;
            set => isUseAUXGNSSChb.Checked = value;
        }

        BaudRate AUXGNSSBaudrate
        {
            get => (BaudRate)Enum.Parse(typeof(BaudRate), auxGNSSBaudrateCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(auxGNSSBaudrateCbx, value.ToString());
        }

        double salinity_PSU
        {
            get => Convert.ToDouble(styEdit.Value);
            set => UIHelpers.SetNumericEditValue(styEdit, value);
        }

        double maxRange_m
        {
            get => Convert.ToDouble(maxRangeEdit.Value);
            set => UIHelpers.SetNumericEditValue(maxRangeEdit, value);
        }

        double xOffset_m
        {
            get => Convert.ToDouble(xOffsetEdit.Value);
            set => UIHelpers.SetNumericEditValue(xOffsetEdit, value);
        }

        double yOffset_m
        {
            get => Convert.ToDouble(yOffsetEdit.Value);
            set => UIHelpers.SetNumericEditValue(yOffsetEdit, value);
        }

        double angleAdjust_deg
        {
            get => Convert.ToDouble(antennaAdjustAngleEdit.Value);
            set => UIHelpers.SetNumericEditValue(antennaAdjustAngleEdit, value);
        }
        
        BaudRate OutputPortBaudrate
        {
            get => (BaudRate)Enum.Parse(typeof(BaudRate), outputPortBaudrateCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(outputPortBaudrateCbx, value.ToString());
        }

        public SettingsContainer Value
        {
            get
            {
                SettingsContainer result = new SettingsContainer
                {
                    AddressMask = addrMask,
                    UseAUXGNSSCompas = isUseAUXGNSS,
                    AUXGNSSCompasBaudrate = AUXGNSSBaudrate,
                    Salinity_PSU = salinity_PSU,
                    MaxDist_m = maxRange_m,
                    TransverseOffset_m = xOffset_m,
                    LongitudalOffset_m = yOffset_m,
                    HeadingAdjust_deg = angleAdjust_deg,
                    SerialOutputPortBaudrate = OutputPortBaudrate
                };

                return result;                    
            }
            set
            {
                addrMask = value.AddressMask;
                isUseAUXGNSS = value.UseAUXGNSSCompas;
                AUXGNSSBaudrate = value.AUXGNSSCompasBaudrate;
                salinity_PSU = value.Salinity_PSU;
                maxRange_m = value.MaxDist_m;
                xOffset_m = value.TransverseOffset_m;
                yOffset_m = value.LongitudalOffset_m;
                angleAdjust_deg = value.HeadingAdjust_deg;
                OutputPortBaudrate = value.SerialOutputPortBaudrate;
            }
        }


        #endregion

        #region Constructor

        public SettingsEditor()
        {
            InitializeComponent();

            remotesList.Items.Clear();
            var items = Enum.GetValues(typeof(REMOTE_ADDR_Enum));

            foreach (REMOTE_ADDR_Enum rAddr in items)
            {
                if (rAddr != REMOTE_ADDR_Enum.REM_ADDR_INVALID)
                    remotesList.Items.Add(rAddr);            
            }

            var bRates = Enum.GetNames(typeof(BaudRate));

            auxGNSSBaudrateCbx.Items.Clear();
            auxGNSSBaudrateCbx.Items.AddRange(bRates);
            AUXGNSSBaudrate = BaudRate.baudRate9600;

            outputPortBaudrateCbx.Items.Clear();
            outputPortBaudrateCbx.Items.AddRange(bRates);
            OutputPortBaudrate = BaudRate.baudRate9600;         
        }

        #endregion

        #region Methods

        private void CheckValidity()
        {
            okBtn.Enabled = remotesList.CheckedItems.Count > 0;
        }

        #endregion

        #region Handlers

        private void remotesCheckAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < remotesList.Items.Count; i++)
                remotesList.SetItemChecked(i, true);
        }

        private void remotesUncheckAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < remotesList.Items.Count; i++)
                remotesList.SetItemChecked(i, false);
        }

        private void isUseAUXGNSSChb_CheckedChanged(object sender, EventArgs e)
        {
            auxGNSSGroup.Enabled = isUseAUXGNSS;
        }

        private void setDaultsBtn_Click(object sender, EventArgs e)
        {
            Value = new SettingsContainer();
        }

        private void styDialogBtn_Click(object sender, EventArgs e)
        {
            using (SalinityDialog sDialog = new SalinityDialog())
            {
                sDialog.Text = LocalisedStrings.SettingsEditor_WaterSalinityDialogTitle;
                if (sDialog.ShowDialog() == DialogResult.OK)
                {
                    salinity_PSU = sDialog.Salinity;
                }
            }
        }

        private void remotesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            okBtn.Enabled =
                (!((remotesList.CheckedItems.Count == 1) && (e.NewValue == CheckState.Unchecked)));
        }

        #endregion
    }
}
