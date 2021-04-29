using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.MODEL
{
    public class Sale
    {
        public string date { get; set; }
        public Product product { get; set; }
        public string count { get; set; }
        public string total { get; set; }
    }
}
