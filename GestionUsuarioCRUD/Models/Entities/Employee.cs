using GestionUsuarioCRUD.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionUsuarioCRUD.Models.Entities
{
    public class Employee : Persona, IEquatable<Employee>
    {
        [Required]
        [Column(TypeName = "int(2)")]
        public TipoEmpleado TipoEmpleado { get; set; }

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
            if (this.TipoEmpleado == TipoEmpleado.Contrato)
                return (this.PrecioHora ?? 0) * (this.HorasTrabajadas ?? 0);

            return (SalarioBase ?? 0) + (Bonificacion ?? 0);
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
