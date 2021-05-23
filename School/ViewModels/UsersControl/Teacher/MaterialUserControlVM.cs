using School.Helpers;
using School.Views.LogInView;
using School.Views.MasterView;
using School.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.Teacher
{
    class MaterialUserControlVM
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
                    Switcher.Switch(new TeacherUserControl());
                    break;
                case "2":
                    Switcher.Switch(new MasterUserControl());
                    break;
                case "3":
                    Switcher.Switch(new LogInUserControl());
                    break;
                case "4":
                    Switcher.pageSwitcher.Close();
                    break;
                case "5":
                    EditMaterial();
                    break;
                case "6":
                    DeleteMaterial();
                    break;
                case "7":
                    AddMaterial();
                    break;
                case "8":
                    SaveMaterial();
                    break;

            }
        }

        private void SaveMaterial()
        {
            throw new NotImplementedException();
        }

        private void AddMaterial()
        {
            throw new NotImplementedException();
        }

        private void DeleteMaterial()
        {
            throw new NotImplementedException();
        }

        private void EditMaterial()
        {
            throw new NotImplementedException();
        }
    }
}
