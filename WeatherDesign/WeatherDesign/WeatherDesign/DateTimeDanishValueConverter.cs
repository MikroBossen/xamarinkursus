using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherDesign
{
    class DateTimeDanishValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime outDate = (DateTime)value;
            CultureInfo cultureDK = new System.Globalization.CultureInfo("da-DK");
            string dag = outDate.Day.ToString();
            string maned = outDate.ToString("MMMM", CultureInfo.InvariantCulture);
            string weekDayDA = cultureDK.DateTimeFormat.GetDayName(outDate.DayOfWeek);
            string returstreng = "";

            returstreng = UppercaseFirst(weekDayDA) + ", d. " + dag + ". " + maned;
            return returstreng;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
