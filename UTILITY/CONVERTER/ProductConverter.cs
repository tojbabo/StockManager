using StockManager.MODEL;
using StockManager.VIEWMODEL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.UTILITY.CONVERTER
{
    public class ProductConverter : ABSTRACT.CONVERTER
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                Product p = ((Sale)value).product;
                if (p == null) return -1;

                var v = CORE.getCORE().GetSale().products;

                var target = v.Where(x => x.code == p.code).FirstOrDefault();

                int idx = v.IndexOf(target);



                return idx;
            }
            catch
            {
                return -1;
            }

        }
    }
}
