using GestionUsuarioCRUD.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionUsuarioCRUD.Models.Entities
{
    public class Employee : Persona, IEquatable<Employee>
    {

        [Required]
        public TipoEmpleado TipoEmpleado { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal SalarioBase { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal? Bonificacion { get; set; }

        [Column(TypeName = "decimal(2,1)")]
        public decimal? HorasTrabajadas { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal? PrecioHora { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? UltimoSalarioTotal { get; set; }

        public Employee(int id, string nombre) : base(id, nombre)
        {
        }

        public override decimal GetSalario()
        {
            return this.SalarioBase;
        }

        public bool Equals(Employee? other)
        {
            if(other == null) return false;

            return this.Nombre.Equals(other.Nombre)
                && this.TipoEmpleado.Equals(other.TipoEmpleado)
                && this.SalarioBase.Equals(other.SalarioBase)
                && this.Bonificacion.Equals(other.Bonificacion)
                && this.HorasTrabajadas.Equals(other.HorasTrabajadas)
                && this.PrecioHora.Equals(other.PrecioHora)
                && this.UltimoSalarioTotal.Equals(other.UltimoSalarioTotal);


        }
    }
}
