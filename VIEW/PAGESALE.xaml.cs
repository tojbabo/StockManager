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


        /// <summary>
        /// 콤보 박스선택 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*var v = sender as ComboBox;
            var d = (Grid)v.Parent;                     // 여기까진 맞다
            
            var s = (ListBox)d.Parent;
            int num = listbox.Items.IndexOf(s);
*/
            for(int i = 0; i < listbox.Items.Count; i++)
            {
                ListBoxItem lbx = (ListBoxItem)listbox.ItemContainerGenerator.ContainerFromItem(listbox.Items[i]);
                ContentPresenter con = FindVisualChild<ContentPresenter>(lbx);

                DataTemplate d = con.ContentTemplate;

                ComboBox b = (ComboBox)d.FindName("combo", con);

                var z = (Product)b.SelectedItem;


            }


            vm.ListADD();
        }
        private ChildControl FindVisualChild<ChildControl>(DependencyObject DependencyObj)
        where ChildControl : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(DependencyObj); i++)
            {
                DependencyObject Child = VisualTreeHelper.GetChild(DependencyObj, i);

                if (Child != null && Child is ChildControl)
                {
                    return (ChildControl)Child;
                }
                else
                {
                    ChildControl ChildOfChild = FindVisualChild<ChildControl>(Child);

                    if (ChildOfChild != null)
                    {
                        return ChildOfChild;
                    }
                }
            }
            return null;
        }
    }
}
