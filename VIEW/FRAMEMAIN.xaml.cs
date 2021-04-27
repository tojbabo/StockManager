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
    /// MAINFRAME.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FRAMEMAIN : Window
    {
        private PAGEINPUT page_input;
        private PAGEMATERIAL page_material;
        private PAGESALE page_sale;
        public FRAMEMAIN()
        {
            InitializeComponent();
            PageLoad();
            FRAME.Navigate(page_material);
        }

        private void PageLoad()
        {
            page_input = new PAGEINPUT();
            page_material = new PAGEMATERIAL();
            page_sale = new PAGESALE();
        }


        private void Btn_Input(object sender, RoutedEventArgs e)
        {
            FRAME.Navigate(page_input);

        }
        private void Btn_Material(object sender, RoutedEventArgs e)
        {
            FRAME.Navigate(page_material);

        }
        private void Btn_Sale(object sender, RoutedEventArgs e)
        {
            FRAME.Navigate(page_sale);
        }
    }
}
