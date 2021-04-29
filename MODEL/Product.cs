using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.MODEL
{
    public class Product
    {
        public string code { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string price { get; set; }

        public new string ToString()
        {
            return $"{code},{category},{name},{price}";
        }
    }
}
