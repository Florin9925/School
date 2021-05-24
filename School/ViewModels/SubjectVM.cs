using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ViewModels
{
    class SubjectVM : BaseVM
    {
        public SubjectVM(Models.Subject subject)
        {
            _IdSubject = subject.id_subject;
            _Name = subject.name;
            _Term = subject.term;
        }
        public SubjectVM()
        {

        }
        private int _IdSubject;
        public int IdSubject
        {
            get => _IdSubject;
            set => SetProperty(ref _IdSubject, value);
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        private int _Term;
        public int Term
        {
            get => _Term;
            set => SetProperty(ref _Term, value);
        }
    }
}
