using StockManager.ABSTRACT;
using StockManager.MODEL;
using StockManager.UTILITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 원준이 원래 만들어놨던 VM_INPUT을 참고하기 위해 옮겨놓음
/// </summary>
namespace StockManager.VIEWMODEL
{
    class VM_INPUT_TEST : VM
    {
        private string _test;

        public string test
        {
            get => _test;
            set
            {
                _test = value;
                OnPropertyChanged(nameof(test));//?
            }
        }

        public ObservableCollection<ListData> list { get; set; }//리스트랑 같은 느낌

        public VM_INPUT_TEST()
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
