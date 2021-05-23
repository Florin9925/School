using School.Helpers;
using School.Views.LogInView;
using School.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.Master
{
    class MasterUserControlVM
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
                    Switcher.Switch(new LogInUserControl());
                    break;
                case "3":
                    Switcher.pageSwitcher.Close();
                    break;
                case "4":
                    ShowAllStudents();
                    break;
                case "5":
                    ShowStudentTermSituation();
                    break;
                case "6":
                    ShowClassSituation();
                    break;
                case "7":
                    SworAwardStudents();
                    break;
                case "8":
                    ShowCorrectingStudents();
                    break;
                case "9":
                    ShowExpelledStudents();
                    break;
                case "10":
                    JustifyAbsence();
                    break;
                case "11":
                    ShowUnjustifyAbsence();
                    break;
                case "12":
                    AllAbsence();
                    break;
                case "13":
                    AllUnjustifyAbsence();
                    break;


            }
        }

        private void AllUnjustifyAbsence()
        {
            throw new NotImplementedException();
        }

        private void AllAbsence()
        {
            throw new NotImplementedException();
        }

        private void ShowUnjustifyAbsence()
        {
            throw new NotImplementedException();
        }

        private void JustifyAbsence()
        {
            throw new NotImplementedException();
        }

        private void ShowExpelledStudents()
        {
            throw new NotImplementedException();
        }

        private void ShowCorrectingStudents()
        {
            throw new NotImplementedException();
        }

        private void SworAwardStudents()
        {
            throw new NotImplementedException();
        }

        private void ShowClassSituation()
        {
            throw new NotImplementedException();
        }

        private void ShowStudentTermSituation()
        {
            throw new NotImplementedException();
        }

        private void ShowAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
