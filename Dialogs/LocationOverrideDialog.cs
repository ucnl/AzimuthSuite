using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzimuthSuite.Dialogs
{
    public partial class LocationOverrideDialog : Form
    {
        #region Properties

        public double Latitude_deg
        {
            get { return Convert.ToDouble(latDegEdit.Value); }
            set { UCNLUI.UIHelpers.SetNumericEditValue(latDegEdit, value); }
        }

        public double Longitude_deg
        {
            get {  return Convert.ToDouble(lonDegEdit.Value); }
            set { UCNLUI.UIHelpers.SetNumericEditValue(lonDegEdit, value); }
        }

        public double Heading_deg
        {
            get {  return Convert.ToDouble(headingEdit.Value); }
            set {  UCNLUI.UIHelpers.SetNumericEditValue(headingEdit, value); }
        }

        #endregion

        #region Constructor

        public LocationOverrideDialog()
        {
            InitializeComponent();
        }

        #endregion
    }
}
