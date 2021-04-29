using StockManager.ABSTRACT;
using StockManager.MODEL;
using StockManager.UTILITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StockManager.VIEWMODEL
{
    public class VM_STUFF : VM
    {
        public VM_STUFF()
        {
            StuffLoad();
        }
        
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

        private string path = @"db-stuff";

        public void StuffLoad() {
           
            var lines = FILE.read(path);

            if (lines == null) return;

            foreach(string line in lines)
            {
                var datas = line.Split(',');
                items.Add(new Stuff
                {
                    code = Convert.ToInt32(datas[0]),
                    category = datas[1],
                    item = datas[2],
                    price = datas[3],
                });
            }

        }
        public void StuffAdd(string datas)
        {
            var data = datas.Split(',');
            items.Add(new Stuff
            {
                code = items.Count,
                category = data[0],
                item = data[1],
                price = data[2],
            }) ;
        }
        public void StuffSave()
        {
            List<string> datas = new List<string>();
            foreach (Stuff s in items)
                datas.Add(s.ToString());
            FILE.write(path,datas,false);
        }
        public void StuffDel(List<Stuff> datas)
        {
            foreach(var item in datas)
            {
                items.Remove(item);
            }
        }
        #endregion

    }
}
