﻿using School.Helpers;
using School.Models.Actions.Admin;
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
    class AddStudentUserControlVM
    {
        private ICommand _AddStudent;
        public ICommand AddStudent
        {
            get
            {
                if (_AddStudent == null)
                {
                    _AddStudent = new RelayCommand((new EditStudentAction()).AddStudent);
                }
                return _AddStudent;
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
                case "1":
                    Switcher.Switch(new EditStudentUserControl());
                    break;
                case "2":
                    Switcher.Switch(new LogInUserControl());
                    break;
                case "3":
                    Switcher.pageSwitcher.Close();
                    break;
            }
        }
    }
}
