using School.Helpers;
using School.ViewModels;
using School.ViewModels.UsersControl.Admin;
using School.Views.AdminView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models.Actions.Admin
{
    class EditTeacherSubjectAction
    {
        public void EditTeacher(object obj)
        {
            TeacherVM teacher = obj as TeacherVM;

            SchoolDBEntities context = new SchoolDBEntities();

            context.AdminModifyPerson(teacher.IdTeacher, teacher.Person.FirstName, teacher.Person.LastName, teacher.Person.Username, teacher.Person.Password);

        }

        public void DeleteTeacher(object obj)
        {
            TeacherVM teacher = obj as TeacherVM;

            SchoolDBEntities context = new SchoolDBEntities();

            //delete

            Switcher.Switch(new EditTeacherSubjectUserControl());
        }
    }
}
