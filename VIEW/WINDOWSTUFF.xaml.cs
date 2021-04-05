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
using System.Windows.Shapes;

namespace StockManager.VIEW
{
    public partial class WINDOWSTUFF : Window
    {
        CORE core;
        VM_STUFF vm;
        public WINDOWSTUFF()
        {
            InitializeComponent();
            core = CORE.getCORE();
            vm = core.GetStuff();

            this.DataContext = vm;
        }

        private void Btn_Add(object sender, RoutedEventArgs e)
        {
            vm.f(NAME.Text);
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            vm.save();
        }
    }
}