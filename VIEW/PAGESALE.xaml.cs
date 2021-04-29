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
    /// PAGESALE.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PAGESALE : Page
    {
        CORE core;
        VM_SALE vm;
        public PAGESALE()
        {
            InitializeComponent();
            core = CORE.getCORE();
            vm = core.GetSale();

            this.DataContext = vm;
        }

        private void Btn_ADD(object sender, RoutedEventArgs e)
        {
            vm.ListADD();
        }

        private void Btn_SAVE(object sender, RoutedEventArgs e)
        {
            vm.ListSAVE();
        }

        private void Btn_RESET(object sender, RoutedEventArgs e)
        {
            vm.ListRESET();
        }

        private void Btn_MODIFY(object sender, RoutedEventArgs e)
        {
            vm.ProductMODIFY();
        }



        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.ListADD();

        }
    }
}
