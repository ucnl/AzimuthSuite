﻿using AzimuthSuite.AzmCore;
using System;
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

        bool isUseMagneticCompass
        {
            get => isUseMagneticCompassChb.Checked;
            set => isUseMagneticCompassChb.Checked = value;
        }

        bool isUseMagneticCompassOnly
        {
            get => IsUseMagneticCompassOnlyChb.Checked;
            set => IsUseMagneticCompassOnlyChb.Checked = value;
        }

        BaudRate AUXGNSSBaudrate
        {
            get => (BaudRate)Enum.Parse(typeof(BaudRate), auxGNSSBaudrateCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(auxGNSSBaudrateCbx, value.ToString());
        }

        BaudRate MagneticCompassBaudrate
        {
            get => (BaudRate)Enum.Parse(typeof(BaudRate), magneticCompassBaudrateCbx.SelectedItem.ToString());
            set => UIHelpers.TrySetCbxItem(magneticCompassBaudrateCbx, value.ToString());
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

        bool specControlsEnabled = false;
        string customLabel = string.Empty;
        string cultureOverride = string.Empty;
        bool isExtendedHolidays = true;

        public SettingsContainer Value
        {
            get
            {
                SettingsContainer result = new SettingsContainer
                {
                    AddressMask = addrMask,
                    UseAUXGNSS = isUseAUXGNSS,
                    UseMagneticCompass = isUseMagneticCompass,
                    AUXGNSSBaudrate = AUXGNSSBaudrate,
                    MagneticCompassBaudrate = MagneticCompassBaudrate,
                    Salinity_PSU = salinity_PSU,
                    MaxDist_m = maxRange_m,
                    TransverseOffset_m = xOffset_m,
                    LongitudalOffset_m = yOffset_m,
                    HeadingAdjust_deg = angleAdjust_deg,
                    SerialOutputPortBaudrate = OutputPortBaudrate,
                    IsUseMagneticCompassOnly = isUseMagneticCompassOnly,
                    SpecControlsEnabled = specControlsEnabled,
                    CustomLabel = customLabel,
                    CultureOverride = cultureOverride,
                    IsExtendedHolidays = isExtendedHolidays
                };

                return result;                    
            }
            set
            {
                addrMask = value.AddressMask;
                isUseAUXGNSS = value.UseAUXGNSS;
                isUseMagneticCompass = value.UseMagneticCompass;
                AUXGNSSBaudrate = value.AUXGNSSBaudrate;
                MagneticCompassBaudrate = value.MagneticCompassBaudrate;
                salinity_PSU = value.Salinity_PSU;
                maxRange_m = value.MaxDist_m;
                xOffset_m = value.TransverseOffset_m;
                yOffset_m = value.LongitudalOffset_m;
                angleAdjust_deg = value.HeadingAdjust_deg;
                OutputPortBaudrate = value.SerialOutputPortBaudrate;
                isUseMagneticCompassOnly = value.IsUseMagneticCompassOnly;
                specControlsEnabled = value.SpecControlsEnabled;
                customLabel = value.CustomLabel;
                cultureOverride = value.CultureOverride;
                isExtendedHolidays = value.IsExtendedHolidays;
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

            magneticCompassBaudrateCbx.Items.Clear();
            magneticCompassBaudrateCbx.Items.AddRange(bRates);
            MagneticCompassBaudrate = BaudRate.baudRate9600;

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

            if (!isUseAUXGNSS)
            {
                IsUseMagneticCompassOnlyChb.Checked = false;
                isUseMagneticCompassChb.Checked = false;

            }

            IsUseMagneticCompassOnlyChb.Enabled = isUseAUXGNSS;
            isUseMagneticCompassChb.Enabled = isUseAUXGNSS;
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

        private void isUseMagneticCompassChb_CheckedChanged(object sender, EventArgs e)
        {
            magneticGroup.Enabled = isUseMagneticCompass;
        }
    }
}
