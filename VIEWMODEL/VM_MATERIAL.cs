using StockManager.ABSTRACT;
using StockManager.MODEL;
using StockManager.UTILITY;
using StockManager.VIEW;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public class VM_MATERIAL : VM
    {
        WINDOWSTUFF ws;
        public ObservableCollection<Material> items { get; set; }

        public VM_MATERIAL()
        {
            items = new ObservableCollection<Material>(); //이거 꼭 만들어거 객체 생성해 줘야됨 아니면 역참조 에러남 시발!!!
        }
        public void ModifyStuff()
        {
            if (ws == null) { 
                ws = new WINDOWSTUFF(); //원준이 만든 윈도우스터프를 넣어서 생성
                ws.Closed += (s, e) => StuffWindowClose();
            }
            ws.Focus();
            ws.Show();
        }
        private void StuffWindowClose()
        {
            ws.Closed -= (s, e) => StuffWindowClose();
            ws = null;
        }

        internal void contentAdd()
        {
            items.Add(new Material("",0,"",""));
        }
    }
}
