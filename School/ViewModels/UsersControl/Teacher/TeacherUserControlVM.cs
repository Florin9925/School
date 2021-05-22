using School.Helpers;
using School.Views.LogInView;
using School.Views.MasterView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.Teacher
{
    class TeacherUserControlVM
    {
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
            switch (nr)
            {
                case "1":
                    Switcher.Switch(new MasterUserControl());
                    break;
                case "2":
                    Switcher.Switch(new LogInUserControl());
                    break;
                case "3":
                    Switcher.pageSwitcher.Close();
                    break;
                case "4":
                    break;

            }
        }
    }
}
