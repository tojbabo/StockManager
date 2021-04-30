using StockManager.MODEL;
using StockManager.VIEWMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            vm.ProductAdd(new Product()
            {
                category = CATEGORY.Text,
                name = NAME.Text,
                price = Convert.ToInt32(PRICE.Text),
                comment = COMMENT.Text
            });
        }

        private void Btn_Del(object sender, RoutedEventArgs e)
        {
            var items = listbox.SelectedItems.Cast<Product>().ToList();
            vm.ProductsDel(items);
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            vm.ProductsSave();
        }

        /// <summary>
        /// price에 숫자만 입력되도록 
        /// 입력할때 마다 숫자인지 아닌지 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriceTextInputEvent(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+"); 
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
