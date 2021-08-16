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
        public int price { get; set; }
        public string comment { get; set; }

        public Product() { }
        public Product(Product p)
        {
            this.code = p.code;
            this.category = p.category;
            this.name = p.name;
            this.price = p.price;
            this.comment = p.comment;
        }
        public new string ToString()
        {
            return $"{code},{category},{name},{price},{comment}";
        }
    }
}
