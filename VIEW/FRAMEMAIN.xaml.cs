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
        private PAGEMATERIAL page_material;
        private PAGESALE page_sale;
        public FRAMEMAIN()
        {
            InitializeComponent();
            PageLoad();
            FRAME.Navigate(page_sale);
        }

        private void PageLoad()
        {
            page_material = new PAGEMATERIAL();
            page_sale = new PAGESALE();
        }

        Button pre_B;

        #region design event
        private void Button_EXIT(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Button_Maximize(object sender, RoutedEventArgs e)
        {
            this.WindowState = (this.WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }

        private void Button_Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && e.ClickCount == 2)
            {
                this.WindowState = (this.WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
            }

        }
        #endregion

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if(b == btn_material)
                FRAME.Navigate(page_material);
            else if(b == btn_sale)
                FRAME.Navigate(page_sale);

            if (pre_B != null) pre_B.Background = new SolidColorBrush(Color.FromRgb(254, 203, 137));

            b.Background = new SolidColorBrush(Color.FromRgb(185, 172, 146)) ;
            
            pre_B = b;
        }
    }
}
