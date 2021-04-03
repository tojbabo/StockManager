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

        private VM_INPUT _vm_input;
        public VM_INPUT GetInput()
        {
            return _vm_input;
        }

        private VM_STUFF _vm_stuff;
        public VM_STUFF GetStuff()
        {
            return _vm_stuff;
        }


        private void Initalize()
        {
            _vm_frame = new VM_FRAME();
            _vm_input = new VM_INPUT();
            _vm_stuff = new VM_STUFF();
        }
    }
}
