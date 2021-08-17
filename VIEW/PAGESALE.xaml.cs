using StockManager.MODEL;
using StockManager.UTILITY;
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

            datepicker.SelectedDate = DateTime.Today;
        }

        private void Btn_ADD(object sender, RoutedEventArgs e)
        {
            vm.ListADD();
        }

        private void Btn_SAVE(object sender, RoutedEventArgs e)
        {
            var when = (DateTime)datepicker.SelectedDate;

            vm.ListSAVE(when);
        }

        private void Btn_RESET(object sender, RoutedEventArgs e)
        {
            vm.ListRESET();
        }

        private void Btn_MODIFY(object sender, RoutedEventArgs e)
        {
            vm.ProductMODIFY();
            DatePicker_Set();
        }


        /// <summary>
        /// 콤보 박스선택 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = sender as ComboBox;
            var item = LISTBOX.GetItemfromControl<ComboBox>(listbox, combobox, "combo");            /// 정말 중요한 코드
                                                                                                    /// 리스트박스 > 리스트박스 아이템 > 특정 컨트롤
                                                                                                    /// 이벤트가 발생한 특정 컨트롤로부터
                                                                                                    /// 해당 컨트롤을 갖고있는 리스트박스 아이템을 얻어냄
            if (item == null) return;
            var parentsObj = (Sale)item.DataContext;

            parentsObj.product = (Product)combobox.SelectedItem;                                    /// 해당 리스트박스 아이템에 선택된 콤보박스 아이템을 입력함

            vm.ListADD();
        }

        private void DatePicker_SelectinoChanged(object sender, SelectionChangedEventArgs e)
        {
            var datepicker = sender as DatePicker;
            var date = (DateTime)datepicker.SelectedDate;

            vm.SalesLoad(date);
            DatePicker_Set();
        }

        private void Btn_Load(object sender, RoutedEventArgs e)
        {
            vm.SalesLoad((DateTime)datepicker.SelectedDate);
            DatePicker_Set();
        }

        void DatePicker_Set()
        {
            listbox.UpdateLayout();

            var sales = vm.Sales;
            var products = vm.products;


            for (int i = 0; i < sales.Count; i++)
            {
                if (sales[i].product == null) continue;

                var lbitem = LISTBOX.Getcontrolfromidx<ComboBox>(listbox, i, "combo");

                if (lbitem == null) continue;

                var tmp = products.Where(x => x.code == sales[i].product.code).FirstOrDefault();
                var idx = products.IndexOf(tmp);

                lbitem.SelectedIndex = idx;
            }

        }

        private void onLoad(object sender, RoutedEventArgs e)
        {
            DatePicker_Set();
        }
    }
}
