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

        public bool IsUseOutputport;
        public BaudRate OutPortBaudrate;
        public REMOTE_ADDR_Enum RemoteAddressToOutput;

        public double HeadingAdjust_deg;
        public double LongitudalOffset_m;
        public double TransverseOffset_m;
        
        public double Salinity_PSU;
        public ushort AddressMask;
        public double MaxDist_m;

        #endregion

        #region Constructor


        #endregion

        #region Methods

        public override void SetDefaults()
        {
            UseAUXGNSSCompas = false;
            AUXGNSSCompasBaudrate = BaudRate.baudRate38400;

            IsUseOutputport = false;
            OutPortBaudrate = BaudRate.baudRate9600;
            RemoteAddressToOutput = REMOTE_ADDR_Enum.REM_ADDR_1;

            HeadingAdjust_deg = 0;
            LongitudalOffset_m = 0;
            TransverseOffset_m = 0;

            Salinity_PSU = PHX.PHX_FWTR_SALINITY_PSU;

            AddressMask = 1;
            MaxDist_m = 1000;
        }

        #endregion
    }
}
