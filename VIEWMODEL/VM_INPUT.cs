﻿using StockManager.MODEL;
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
        public ObservableCollection<ListData> list { get; set; }//리스트랑 같은 느낌
        public string test{get;set;}

        public VM_INPUT()
        {
            list = new ObservableCollection<ListData>();
            test = null;
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
         public void datawrite2(string data)
        {
            FILE.write(data);
            
            test = data;
        }

    }
}
