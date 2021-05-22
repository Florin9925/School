using School.Helpers;
using School.Views.AdminView;
using School.Views.LogInView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.Admin
{
    class EditTeacherSubjectUserControlVM
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
                    Switcher.Switch(new AdminUserControl());
                    break;
                case "2":
                    Switcher.Switch(new LogInUserControl());
                    break;
                case "3":
                    Switcher.pageSwitcher.Close();
                    break;
                case "4":
                    EditTeacher();
                    break;
                case "5":
                    DeleteTeacher();
                    break;
                case "6":
                    AddTeacher();
                    break;
                case "7":
                    SaveTeacher();
                    break;
                case "8":
                    EditSubject();
                    break;
                case "9":
                    DeleteSubject();
                    break;
                case "10":
                    AddSubject();
                    break;
                case "11":
                    SaveSubject();
                    break;
            }
        }

        public void AddTeacher()
        {
            throw new NotImplementedException();
        }

        public void DeleteTeacher()
        {
            throw new NotImplementedException();
        }

        public void EditTeacher()
        {
            throw new NotImplementedException();
        }

        public void SaveTeacher()
        {
            throw new NotImplementedException();
        }

        public void AddSubject()
        {
            throw new NotImplementedException();
        }

        public void DeleteSubject()
        {
            throw new NotImplementedException();
        }

        public void EditSubject()
        {
            throw new NotImplementedException();
        }

        public void SaveSubject()
        {
            throw new NotImplementedException();
        }
    }
}
