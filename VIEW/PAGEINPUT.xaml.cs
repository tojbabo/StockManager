using StockManager.VIEWMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockManager.VIEW
{
    /// <summary>
    /// PAGEINPUT.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PAGEINPUT : Page
    {
        CORE core;
        VM_INPUT vm;
        public PAGEINPUT()
        {
            InitializeComponent();
            core = CORE.getCORE();
            vm = core.GetVmInput();

            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.datawrite(C_data.Text);
            C_data.Text = "";
        }
    }
}
