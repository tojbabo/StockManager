using StockManager.ABSTRACT;
using StockManager.MODEL;
using StockManager.UTILITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public class VM_PRODUCT : VM
    {
        VM_SALE vm;

        public ObservableCollection<Product> products { get => vm.products; }
        private string _path= @"db-product";
        public VM_PRODUCT(VM_SALE v)
        {
            vm = v;
        }
        public void ProductAdd(Product p)
        {
            p.code = Convert.ToString(products.Count());
            products.Add(p);
        }
        

        public void ProductsDel(List<Product> items)
        {
            foreach(var v in items)
            {
                products.Remove(v);
            }
        }

        public void ProductsSave()
        {
            List<string> datas = new List<string>();
            foreach (var v in products)
                datas.Add(v.ToString());
            FILE.write(_path, datas, false);
        }
    }
}
