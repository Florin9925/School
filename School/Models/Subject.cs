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
    
    public partial class Subject
    {
        public Subject()
        {
            this.Class_Subject = new HashSet<Class_Subject>();
        }
    
        public byte id_subject { get; set; }
        public string name { get; set; }
        public byte term { get; set; }
    
        public virtual ICollection<Class_Subject> Class_Subject { get; set; }
        public virtual Term Term1 { get; set; }
    }
}
