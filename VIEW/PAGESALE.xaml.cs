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
            var combobox = sender as ComboBox;

            var num = LISTBOX.GetItemfromControl<ComboBox>(listbox, combobox, "combo");             /// 정말 중요한 코드
                                                                                                    /// 리스트박스 > 리스트박스 아이템 > 특정 컨트롤
                                                                                                    /// 이벤트가 발생한 특정 컨트롤로부터
                                                                                                    /// 해당 컨트롤을 갖고있는 리스트박스 아이템을 얻어냄
            var parentsObj = (Sale)num.DataContext;

            parentsObj.product = (Product)combobox.SelectedItem;                                    /// 해당 리스트박스 아이템에 선택된 콤보박스 아이템을 입력함



            vm.ListADD();
        }

        private void PriceTextInputEvent(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

           
        }
    }
}
