using StockManager.ABSTRACT;
using StockManager.MODEL;
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

        public VM_PRODUCT(VM_SALE v)
        {
            vm = v;
        }
        public void ListADD(Product p)
        {
            products.Add(p);
        }
    }
}
