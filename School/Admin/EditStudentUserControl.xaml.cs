using School.Log_in;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for EditStudentUserControl1.xaml
    /// </summary>
    public partial class EditStudentUserControl : UserControl
    {
        ObservableCollection<Person> Persons { get; set; }
        public EditStudentUserControl()
        {
            InitializeComponent();
            Persons = new ObservableCollection<Person>();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AdminUserControl());
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LogInUserControl());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.pageSwitcher.Close();
        }
    }
}
