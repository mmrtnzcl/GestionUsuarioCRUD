using GestionUsuarioCRUD.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionUsuarioCRUD.Models.Entities
{
    public class Employee : Persona
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

        [Column(TypeName = "decimal(3,2)")]
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
    }
}
