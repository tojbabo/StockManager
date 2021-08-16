using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.UTILITY
{
    public static class Util
    {
        public static string Date2Str(DateTime date)
        {
            return $"_{date.Year}{date.Month}{date.Day}";
        }
    }
}
