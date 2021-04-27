using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public class VM_SALE
    {
        public ObservableCollection<int> items { get; set; }

        public VM_SALE()
        {
            items = new ObservableCollection<int>();
            items.Add(4);
            items.Add(4);
            items.Add(4);
            items.Add(4);
            items.Add(4);
        }
        public void f()
        {
            items.Add(1);
        }

    }
}
