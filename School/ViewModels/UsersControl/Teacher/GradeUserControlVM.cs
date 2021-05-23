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
    class GradeUserControlVM
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
                    CancelsGrade();
                    break;
                case "6":
                    AddGrade();
                    break;
                case "7":
                    SaveGrade();
                    break;
                case "8":
                    MakeSituation();
                    break;
                case "9":
                    ShowSituation();
                    break;

            }
        }

        private void ShowSituation()
        {
            throw new NotImplementedException("aici se va face implementarea pentru afisarea situatiei unui elev");
        }

        private void MakeSituation()
        {
            throw new NotImplementedException("aici se va implementa funtia prin care se calculeaza situatia unui elev");
        }

        private void SaveGrade()
        {
            throw new NotImplementedException("aici se va face implementarea pentru functia carea va adauga o nota elevului asta dupa ce s-a apasat pe add grade si s-au completat campurile necesare");
        }

        private void AddGrade()
        {
            throw new NotImplementedException("aici se va implementa functia prin care se golesc campurile de editare pentru grade ca sa se poata introduce datele pentru o noua nota");
        }

        private void CancelsGrade()
        {
            throw new NotImplementedException("aici se va anula nota");
        }
    }
}
