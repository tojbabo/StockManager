using StockManager.MODEL;
using StockManager.UTILITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public class VM_STUFF : VM
    {
        #region property
        private ObservableCollection<Stuff> _items;
        public ObservableCollection<Stuff> items
        {
            get
            {
                if (_items == null) 
                    _items = new ObservableCollection<Stuff>();
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged(nameof(items));
            }
        }
        #endregion

        #region method

        public void f(string data)
        {
            items.Add(new Stuff
            {
                id = items.Count,
                name = data,
            }) ;
        }
        public void save()
        {
            List<string> datas = new List<string>();
            foreach (Stuff s in items)
                datas.Add(s.ToString());
            FILE.write(@"tt",datas);
        }
        #endregion

    }
}
