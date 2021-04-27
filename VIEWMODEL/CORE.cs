using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public sealed class CORE
    {
        private static CORE _core = null;
        public static CORE getCORE()
        {
            if (_core == null)
            {
                _core = new CORE();
                _core.Initalize();
            }
            return _core;
        }

        private VM_FRAME _vm_frame;
        public VM_FRAME GetFrame()
        {
            return _vm_frame;
        }

        private VM_MATERIAL _vm_material;
        public VM_MATERIAL GetMaterial()
        {
            return _vm_material;
        }

        private VM_SALE _vm_sale;
        public VM_SALE GetSale()
        {
            return _vm_sale;
        }

        //private VM_STUFF _vm_stuff;
        //public VM_STUFF GetStuff()
        //{
        //    return _vm_stuff;
        //}


        private void Initalize()
        {
            _vm_frame = new VM_FRAME();
            _vm_material = new VM_MATERIAL();
            _vm_sale = new VM_SALE();
            //_vm_stuff = new VM_STUFF();
        }
    }
}
