﻿using School.Admin;
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

namespace School.Log_in
{
    /// <summary>
    /// Interaction logic for LogInUserControl.xaml
    /// </summary>
    public partial class LogInUserControl : UserControl
    {
        public LogInUserControl()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AdminUserControl());
        }
    }
}
