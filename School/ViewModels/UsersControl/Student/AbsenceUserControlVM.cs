﻿using School.Helpers;
using School.Models;
using School.Views.LogInView;
using School.Views.StudentView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.Student
{
    class AbsenceUserControlVM
    {
        public ObservableCollection<AbsenceVM> Absences { get; set; }


        SchoolDBEntities context = new SchoolDBEntities();

        public AbsenceUserControlVM()
        {
            Absences = new ObservableCollection<AbsenceVM>();

            var temp = context.GetAllAbsenceBySubject(StudentUserControlVM.CURRENT_SUBJECT, StudentUserControlVM.CURRENT_STUDENT);
            foreach (var absence in temp)
            {
                Absences.Add(new AbsenceVM()
                {
                    IdAbsence = absence.id_absence, 
                    Date = absence.date,
                    IsJustified = absence.is_justified, 
                    CanBeJustified = absence.can_be_justified 
                }
                );
            }

        }


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
                case "back":
                    Switcher.Switch(new StudentUserControl());
                    break;
                case "log_out":
                    Switcher.Switch(new LogInUserControl());
                    break;
                case "exit":
                    Switcher.pageSwitcher.Close();
                    break;
            }
        }
    }
}
