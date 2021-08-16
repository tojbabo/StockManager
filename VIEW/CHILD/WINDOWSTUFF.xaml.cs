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

namespace StockManager.VIEW.CHILD
{
    public partial class WINDOWSTUFF : Window
    {
        CORE core;
        VM_STUFF vm;

        public WINDOWSTUFF()
        {
            InitializeComponent();
            core = CORE.getCORE();
            vm = new VM_STUFF();

            this.DataContext = vm;

            //vm.StuffLoad();
        }

        private void Btn_Add(object sender, RoutedEventArgs e)
        {

            vm.StuffAdd($"{CATEGORY.Text},{ITEM.Text},{PRICE.Text}");
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            vm.StuffSave();
        }

        private void Btn_Del(object sender, RoutedEventArgs e)
        {
            var items = listview.SelectedItems.Cast<Stuff>().ToList();

            vm.StuffDel(items);
        }

        #region design event
        private void Button_EXIT(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GridMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        #endregion
    }
}
