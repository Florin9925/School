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
    
    public partial class Absence
    {
        public int id_absence { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<bool> is_justify { get; set; }
        public Nullable<bool> can_justify { get; set; }
        public byte term { get; set; }
        public int fk_student { get; set; }
    
        public virtual Student Student { get; set; }
    }
}