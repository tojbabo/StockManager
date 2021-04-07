﻿using StockManager.VIEWMODEL;
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
    /// PAGEMATERIAL.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PAGEMATERIAL : Page
    {
        CORE core;
        VM_INPUT vm;
        public PAGEMATERIAL()
        {
            InitializeComponent();
            core = CORE.getCORE();
            vm = core.GetInput();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.addMaterial();
        }
    }
}
