using School.Helpers;
using School.Views.AdminView;
using School.Views.LogInView;
using School.Views.StudentView;
using School.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.LogIn
{
    class LogInUserControlVM
    {
        LogInUserControl logInUserControl { get; set; }

        private ICommand openUserControlCommand;
        public ICommand OpenUserControlCommand
        {
            get
            {
                if (openUserControlCommand == null)
                {
                    openUserControlCommand = new RelayCommand(OpenUserControl);
                }
                return openUserControlCommand;
            }
        }

        public void OpenUserControl(object obj)
        {
            string nr = obj as string;
            logInUserControl = Switcher.pageSwitcher.Content as LogInUserControl;

            switch (nr)
            {
                case "1":
                    Switcher.pageSwitcher.Close();
                    break;
                case "2":
                    if (logInUserControl == null)
                        break;
                    if (logInUserControl.textBoxEmail.Text.Equals("admin"))
                        Switcher.Switch(new AdminUserControl());
                    else if (logInUserControl.textBoxEmail.Text.Equals("teacher"))
                        Switcher.Switch(new TeacherUserControl());
                    else
                        Switcher.Switch(new StudentUserControl());
                    break;
            }
        }
    }
}
