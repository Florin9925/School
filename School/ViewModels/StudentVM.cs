using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ViewModels
{
    class StudentVM: BaseVM
    {

        public StudentVM(Models.Student student)
        {
            _Id = student.id_student;
            _IsDebtor = student.is_debtor;
            _AnnualGrade = student.annual_grade;
        }
        public StudentVM()
        {

        }

        private int _Id;
        public int Id
        {
            get => _Id;
            set => SetProperty(ref _Id, value);
        }


        private bool? _IsDebtor;
        public bool? IsDebtor
        {
            get => _IsDebtor;
            set => SetProperty(ref _IsDebtor, value);
        }


        private double? _AnnualGrade;
        public double? AnnualGrade
        {
            get => _AnnualGrade;
            set => SetProperty(ref _AnnualGrade, value);
        }


        //private int _FkClass;
        //public int FkClass
        //{
        //    get => _FkClass;
        //    set => SetProperty(ref _FkClass, value);
        //}

    }
}
