using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StockManager.UTILITY.CONVERTER
{
    public class DateConverter : ABSTRACT.CONVERTER
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string v = System.Convert.ToString(value);

            if (v == "") return DateTime.Now;
            else return DateTime.Parse(v);

        }
    }
}
