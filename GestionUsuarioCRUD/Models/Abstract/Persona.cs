using GestionUsuarioCRUD.Models.Interface;
using System.ComponentModel.DataAnnotations;

namespace GestionUsuarioCRUD.Models.Abstract
{
    public abstract class Persona : IEmployee
    {
        [Key]
        public int Id { get; private set; }
        
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public Persona(int id, string nombre)
        {
            Nombre = nombre;
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Nombre;
        }

        public abstract decimal GetSalario();
    }
}
