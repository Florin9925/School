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
    
    public partial class Material
    {
        public int id_material { get; set; }
        public byte[] type { get; set; }
        public int fk_teacher { get; set; }
        public int fk_class_subject { get; set; }
    
        public virtual Class_Subject Class_Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}