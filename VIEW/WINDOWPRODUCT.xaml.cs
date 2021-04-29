using StockManager.MODEL;
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
using System.Windows.Shapes;

namespace StockManager.VIEW
{
    /// <summary>
    /// WINDOWPRODUCT.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WINDOWPRODUCT : Window
    {
        CORE core;
        VM_PRODUCT vm;
        public WINDOWPRODUCT()
        {
            InitializeComponent();
            core = CORE.getCORE();
            vm = new VM_PRODUCT(core.GetSale());
            this.DataContext = vm;
        }

        private void Btn_Add(object sender, RoutedEventArgs e)
        {
            vm.ListADD(new Product()
            {
                name = CATEGORY.Text,
                price = PRICE.Text

            }) ;
        }

        private void Btn_Del(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {

        }
    }
}
