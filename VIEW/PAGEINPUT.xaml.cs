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
        VM_INPUT_TEST vm_in;
        public PAGEINPUT()
        {
            InitializeComponent();
            core = CORE.getCORE();
            //vm_in = core.GetInput(); //실제로 만들 내용이 아니라 그냥 주석처리
            vm_in = new VM_INPUT_TEST();
            this.DataContext = vm_in;
            ///데이터 바인딩에 참여할 대 요소에 대한 데이터 컨텍스트를 가져오거나 설정
            ///xmal은 xaml.cs와 연결되어 있는데 이에 대한 처리를 하는 cs와 연결하기 위해 사용
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm_in.datawrite2(C_data2.Text);
            vm_in.datawrite(C_data.Text);
            C_data.Text = "";
        }
    }
}
