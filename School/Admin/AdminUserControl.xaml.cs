using School.Log_in;
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

namespace School.Admin
{
    /// <summary>
    /// Interaction logic for AdminUserControl.xaml
    /// </summary>
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }

        private void buttonEditTeacher_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new EditStudentUserControl());
        }

        private void buttonEditStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.pageSwitcher.Close();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LogInUserControl());
        }
    }
}
