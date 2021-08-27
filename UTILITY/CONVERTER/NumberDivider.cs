using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.UTILITY.CONVERTER
{
    public class NumberDivider : ABSTRACT.CONVERTER
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string v = System.Convert.ToString(value);

            bool flag = false;
            if (v[0] == '-')
            {
                v = v.Substring(1);
                flag = true;
            }

            int length = v.Length;

            for (int i = 1; i < length; i++)
                if (i % 3 == 0)
                    v = v.Insert(length - i, ",");

            if (flag == true)
                v = $"-{v}";

            return v;

        }
    }
}
// 10000000000
// 10,000,000,000
// 10, 000, 000, 000