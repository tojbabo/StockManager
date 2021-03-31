using StockManager.MODEL;
using StockManager.UTILITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public class VM_INPUT
    {
        public ObservableCollection<ListData> list { get; set; }

        public VM_INPUT()
        {
            list = new ObservableCollection<ListData>();
        }
        public void datawrite(string data)
        {
            FILE.write(data);
            list.Add(new ListData
            {
                key = data,
                value = data
            });
        }
    }
}
