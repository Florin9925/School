//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Class
    {
        public Class()
        {
            this.Assignments = new HashSet<Assignment>();
            this.Students = new HashSet<Student>();
        }
    
        public int id_class { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public string field { get; set; }
        public Nullable<int> fk_classmaster { get; set; }
    
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
