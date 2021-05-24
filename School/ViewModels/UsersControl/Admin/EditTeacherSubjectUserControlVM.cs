using School.Helpers;
using School.Models;
using School.Views.AdminView;
using School.Views.LogInView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace School.ViewModels.UsersControl.Admin
{

    class EditTeacherSubjectUserControlVM : BaseVM
    {
        public ObservableCollection<TeacherVM> Teachers { get; set; }
        static public ObservableCollection<SubjectVM> Subjects { get; set; }

        public static int CURRENT_TEACHER { get; set; }

        SchoolDBEntities context = new SchoolDBEntities();

        public EditTeacherSubjectUserControlVM()
        {
            Teachers = new ObservableCollection<TeacherVM>();

            Subjects = new ObservableCollection<SubjectVM>();

            var temp = context.AdminGetAllTeachers();
            foreach (var teacher in temp)
            {
                Teachers.Add(new TeacherVM()
                {
                    IdTeacher = teacher.id_person,
                    Person = new PersonVM()
                    {
                        FirstName = teacher.first_name,
                        LastName = teacher.last_name,
                        Password = teacher.password,
                        Username = teacher.username
                    }
                });
            }
            CURRENT_TEACHER = -1;

        }
     


        static int x = 5;
        public bool AddSubject
        {
            get
            {
                var temp = context.GetAllTeacherSubject(x++);

                foreach (var subject in temp)
                {
                    Subjects.Add(new SubjectVM()
                    {
                        IdSubject = subject.id_subject,
                        Name = subject.name,
                        Term = subject.term
                    });
                }

                return false;
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
                    Switcher.Switch(new AdminUserControl());
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
