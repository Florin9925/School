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
    class EditStudentUserControlVM
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
        
        private ICommand selectItem;
        public ICommand SelectItem
        {
            get
            {
                if (selectItem == null)
                {
                    selectItem = new RelayCommand(OpenUserControl);
                }
                return selectItem;
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
                    EditStudent();
                    break;
                case "5":
                    DeleteStudent();
                    break;
                case "6":
                    AddStudent();
                    break;
                case "7":
                    SaveStudent();
                    break;
            }
        }

        private void SaveStudent()
        {
            throw new NotImplementedException();
        }

        private void AddStudent()
        {
            throw new NotImplementedException();
        }

        private void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        private void EditStudent()
        {
            throw new NotImplementedException();
        }
    }
}
