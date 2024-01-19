using AzimuthSuite.AzmCore;
using UCNLDrivers;
using UCNLPhysics;

namespace AzimuthSuite
{
    public class SettingsContainer : SimpleSettingsContainer
    {
        #region Properties

        public bool UseAUXGNSSCompas;
        public BaudRate AUXGNSSCompasBaudrate;

        public BaudRate SerialOutputPortBaudrate;

        public double HeadingAdjust_deg;
        public double LongitudalOffset_m;
        public double TransverseOffset_m;
        
        public double Salinity_PSU;
        public ushort AddressMask;
        public double MaxDist_m;

        public string CustomLabel;

        public string CultureOverride;

        public bool SpecControlsEnabled;

        #endregion

        #region Constructor


        #endregion

        #region Methods

        public override void SetDefaults()
        {
            UseAUXGNSSCompas = false;
            AUXGNSSCompasBaudrate = BaudRate.baudRate38400;

            SerialOutputPortBaudrate = BaudRate.baudRate9600;
            
            HeadingAdjust_deg = 0;
            LongitudalOffset_m = 0;
            TransverseOffset_m = 0;

            Salinity_PSU = PHX.PHX_FWTR_SALINITY_PSU;

            AddressMask = 1;
            MaxDist_m = 1000;

            CustomLabel = string.Empty;
            CultureOverride = string.Empty;

            SpecControlsEnabled = false;
        }

        #endregion
    }
}
