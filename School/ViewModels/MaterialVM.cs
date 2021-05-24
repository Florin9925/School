using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ViewModels
{
    class MaterialVM : BaseVM
    {
        public MaterialVM(Models.Material material)
        {
            _IdMaterial = material.id_material;
            _Type = material.type;
        }
        public MaterialVM()
        {

        }

        private int _IdMaterial;
        public int IdMaterial
        {
            get => _IdMaterial;
            set => SetProperty(ref _IdMaterial, value);
        }

        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetProperty(ref _Type, value);
        }

        //private int _FkAssignment;
        //public int FkAssignment
        //{
        //    get => _FkAssignment;
        //    set => SetProperty(ref _FkAssignment, value);
        //}
    }
}
