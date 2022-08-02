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

        public string OutPortName;
        
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

            OutPortName = "COM1";
        }

        #endregion
    }
}
