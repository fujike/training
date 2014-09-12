﻿using System;
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

namespace answer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void textbox_MouseUp(object sender, RoutedEventArgs e)
        {
            string message = tb2.Text;
            System.Windows.MessageBox.Show(message);
            e.Handled = true;
        }
        void textbox_MouseDoubleClick(object sender, RoutedEventArgs t)
        {
            string message = (sender as TextBox).Text;
            MessageBox.Show(message);
            t.Handled = true;
        }
    }
}
