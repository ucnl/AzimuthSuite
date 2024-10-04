using AzimuthSuite.AzmCore;
using System;
using System.Drawing;
using System.Windows.Forms;
using UCNLDrivers;

namespace AzimuthSuite
{
    [Serializable]
    public class UISettingsContainer : SimpleSettingsContainer
    {
        #region Properties

        public FormWindowState WState;
        public Size WSize;
        public Point WLocation;

        public bool LimboVisible;
        public bool HistoryVisible;
        public bool NotesVisible;
        public bool MiscInfoVisible;

        public bool RemDistanceAzimuthVisible;
        public bool RemDepthVisible;
        public bool RemReverseAzimuthVisible;
        public bool RemElevationVisible;
        public bool RemMiscInfoVisible;
        public bool RemLocationVisible;

        public string VisualStyle;

        public REMOTE_ADDR_Enum RemAddrToOutput;
        public string OutPortName;
        public string UDPOutAddrAndPort;

        public string AZMPreferredPortName;
        public string AUXGNSSCompasPreferredPortName;
        
        #endregion

        #region SimpleSettingsContainer

        public override void SetDefaults()
        {
            WState = FormWindowState.Normal;
            WLocation = new Point(0, 0);

            LimboVisible = true;
            HistoryVisible = true;
            NotesVisible = true;
            MiscInfoVisible = true;

            RemDistanceAzimuthVisible = true;
            RemDepthVisible = true;
            RemReverseAzimuthVisible = true;
            RemElevationVisible = true;
            RemMiscInfoVisible = true;
            RemLocationVisible = true;

            VisualStyle = VisualStyleContainer.DefaultName;

            RemAddrToOutput = REMOTE_ADDR_Enum.REM_ADDR_1;
            OutPortName = "COM1";
            UDPOutAddrAndPort = "255.255.255.255:28128";

            AZMPreferredPortName = string.Empty;
            AUXGNSSCompasPreferredPortName = string.Empty;
    }

        #endregion
    }
}
