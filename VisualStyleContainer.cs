using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using UCNLDrivers;

namespace AzimuthSuite
{
    [Serializable]
    public class VisualStyleContainer : SimpleSettingsContainer
    {
        #region Properties

        public static string DefaultName = "Default Dark 🌙";

        public string Name;

        public string RPlot_Font;
        public string RPlot_BackColor;
        public string RPlot_ForeColor;

        public string RPlot_AxisLabelBackgroundColor;
        public string RPlot_AxisColor;
        public string RPlot_AxisLabelColor;
        public string RPlot_AxisLabelFont;
        
        public string RPlot_BoatColor;
        public int RPlot_BoatSize;
                
        public string RPlot_HistoryTextColor;
        public string RPlot_HistoryTextFont;
        public int RPlot_HistoryLinesNumber;

        public string RPlot_LeftUpperTextBackgroundColor;
        public string RPlot_LeftUpperTextColor;
        public string RPlot_LeftUpperTextFont;

        public string RPlot_LimboColor;
        public int RPlot_LimboThickness;
        public int RPlot_LimboTickAngleStep;
        public LineCap RPlot_LimboTickCap;
        public string RPlot_LimboTickColor;
        public int RPlot_LimboTickThickness;

        public string RPlot_RightUpperTextBackgroundColor;
        public string RPlot_RightUpperTextColor;
        public string RPlot_RightUpperTextFont;

        public string RPlot_TargetCircleColor;
        public string RPlot_TargetDistLineColor;
        public string RPlot_TargetLabelBackgroundColor;
        public string RPlot_TargetLabelColor;
        public string RPlot_TargetLabelFont;

        public string TreeView_BackColor;
        public string TreeView_ForeColor;
        public string TreeView_LineColor;
        public string TreeView_Font;

        #endregion

        #region Methods
        public override void SetDefaults()
        {
            Name = DefaultName;

            RPlot_BackColor = ColorTranslator.ToHtml(Color.Black);
            RPlot_ForeColor = ColorTranslator.ToHtml(Color.White);
            RPlot_Font = "Segoe UI, 10pt";

            RPlot_AxisLabelBackgroundColor = ColorTranslator.ToHtml(Color.Black);
            RPlot_AxisColor = ColorTranslator.ToHtml(Color.LightGray);
            RPlot_AxisLabelColor = ColorTranslator.ToHtml(Color.LightGray);
            RPlot_AxisLabelFont = "Consolas, 12pt";

            RPlot_BoatColor = ColorTranslator.ToHtml(Color.Yellow);
            RPlot_BoatSize = 20;
            
            RPlot_HistoryTextColor = ColorTranslator.ToHtml(Color.SpringGreen);
            RPlot_HistoryLinesNumber = 4;
            RPlot_HistoryTextFont = "Consolas, 9pt";

            RPlot_LeftUpperTextBackgroundColor = ColorTranslator.ToHtml(Color.Transparent);
            RPlot_LeftUpperTextColor = ColorTranslator.ToHtml(Color.GreenYellow);
            RPlot_LeftUpperTextFont = "Consolas, 13.8pt";

            RPlot_LimboColor = ColorTranslator.ToHtml(Color.LightSeaGreen);
            RPlot_LimboThickness = 10;
            RPlot_LimboTickAngleStep = 15;
            RPlot_LimboTickCap = LineCap.Triangle; 
            RPlot_LimboTickColor = ColorTranslator.ToHtml(Color.LightGray);
            RPlot_LimboTickThickness = 10;

            RPlot_RightUpperTextBackgroundColor = ColorTranslator.ToHtml(Color.Black);
            RPlot_RightUpperTextColor = ColorTranslator.ToHtml(Color.PowderBlue);
            RPlot_RightUpperTextFont = "Consolas, 13.8pt";

            RPlot_TargetCircleColor = ColorTranslator.ToHtml(Color.Goldenrod);
            RPlot_TargetDistLineColor = ColorTranslator.ToHtml(Color.Gold);
            RPlot_TargetLabelBackgroundColor = ColorTranslator.ToHtml(Color.Yellow);
            RPlot_TargetLabelColor = ColorTranslator.ToHtml(Color.Black);
            RPlot_TargetLabelFont = "Consolas, 16.2pt";

            TreeView_BackColor = ColorTranslator.ToHtml(Color.Black);
            TreeView_ForeColor = ColorTranslator.ToHtml(Color.LawnGreen);
            TreeView_LineColor = ColorTranslator.ToHtml(Color.LightGreen);
            TreeView_Font = "Consolas, 13.8pt";
    }

        #endregion
    }
}
