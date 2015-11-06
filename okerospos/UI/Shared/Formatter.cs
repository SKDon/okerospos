using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace OBS.Pos.UI.Shared
{
    public class Formatter
    {

        #region Money Formats
        public static void ApplyCurrencyFormat(Binding bindControl)
        {
            // Add the delegates to the event.
            bindControl.Format += new ConvertEventHandler(DecimalToCurrencyString);
            bindControl.Parse += new ConvertEventHandler(CurrencyStringToDecimal);
        }

        #region Support
        public static void DecimalToCurrencyString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("c").
            if (!string.IsNullOrEmpty(cevent.Value.ToString()))
            cevent.Value = ((decimal)cevent.Value).ToString("c");
        }
        public static void CurrencyStringToDecimal(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to decimal type only. 
            if (cevent.DesiredType != typeof(decimal)) return;
            if (!string.IsNullOrEmpty(cevent.Value.ToString()))
            // Converts the string back to decimal using the static Parse method.
            cevent.Value = Decimal.Parse(cevent.Value.ToString(),
            NumberStyles.Currency, null);
        }
        #endregion
        #endregion

        #region Integer Formats
        public static void ApplyFloatFormat(Binding bindControl)
        {
            // Add the delegates to the event.
            bindControl.Format += new ConvertEventHandler(DecimalToFloatString);
            bindControl.Parse += new ConvertEventHandler(FloatStringToDecimal);
        }
        #region Support
        public static void DecimalToFloatString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            if(!string.IsNullOrEmpty(cevent.Value.ToString()))
                cevent.Value = ((decimal)cevent.Value).ToString("###,###,###.00");
        }
        public static void FloatStringToDecimal(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to decimal type only. 
            if (cevent.DesiredType != typeof(decimal)) return;

            // Converts the string back to decimal using the static Parse method.
            cevent.Value = Decimal.Parse(cevent.Value.ToString(),
            NumberStyles.Any, null);
        }
        #endregion
        #endregion
    }
}
