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
        internal void addMaterial()
        {
            throw new NotImplementedException();
        }

        public void ModifyStuff()
        {
            if (ws == null) { 
                ws = new WINDOWSTUFF();
                ws.Closed += (s, e) => StuffWindowClose();
            }
            ws.Focus();
            ws.Show();
        }
        private void StuffWindowClose()
        {
            ws = null;
        }
    }
}
