using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public sealed class CORE
    {
        public static CORE staticCORE = null;
        public static CORE getCORE()
        {
            if (staticCORE == null)
            {
                staticCORE = new CORE();
                staticCORE.Initalize();
            }
            return staticCORE;
        }

        private VM_FRAME vm_frame;
        public VM_FRAME GetVmFrame()
        {
            return vm_frame;
        }

        private VM_INPUT vm_input;
        public VM_INPUT GetVmInput()
        {
            return vm_input;
        }


        private void Initalize()
        {
            vm_frame = new VM_FRAME();
            vm_input = new VM_INPUT();
        }
    }
}
