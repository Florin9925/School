using School.Helpers;
using School.Models;
using School.Views.AdminView;
using School.Views.LogInView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.Admin
{
    class EditStudentUserControlVM : BaseVM
    {
        SchoolDBEntities context = new SchoolDBEntities();

        public ObservableCollection<StudentVM> Students { get; set; }

        EditStudentUserControl _editStudentUserControl;
        EditStudentUserControl editStudentUserControl
        {
            get => _editStudentUserControl;
            set => SetProperty(ref _editStudentUserControl, value);
        }

        public EditStudentUserControlVM()
        {
            Students = new ObservableCollection<StudentVM>();

            var temp = context.AdminGetAllStudents();

            foreach (var student in temp)
            {
                Students.Add(new StudentVM()
                {
                    Id = student.id_person,
                    Person = new PersonVM()
                    {
                        FirstName = student.first_name,
                        LastName = student.last_name,
                        Password = student.password,
                        Username = student.username
                    }
                });
            }
        }

        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;

            set
            {
                if (_selectedIndex == value)
                {
                    return;
                }

                // At this point _selectedIndex is the old selected item's index

                _selectedIndex = value;

                // At this point _selectedIndex is the new selected item's index
                SelectItem();
            }
        }



        public void SelectItem()
        {
            editStudentUserControl = Switcher.pageSwitcher.Content as EditStudentUserControl;
            editStudentUserControl.listStudents.SelectedItem= _selectedIndex;
            var test = editStudentUserControl.listStudents.SelectedItem;
          
            editStudentUserControl.textBoxId.Text = (test as StudentVM).Id.ToString();
            editStudentUserControl.textBoxFirstName.Text = (test as StudentVM).Person.FirstName;
            editStudentUserControl.textBoxLastName.Text = (test as StudentVM).Person.LastName;
            editStudentUserControl.textBoxPassword.Text = (test as StudentVM).Person.Password;
            editStudentUserControl.textBoxUsername.Text = (test as StudentVM).Person.Username;


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
            editStudentUserControl = Switcher.pageSwitcher.Content as EditStudentUserControl;
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
