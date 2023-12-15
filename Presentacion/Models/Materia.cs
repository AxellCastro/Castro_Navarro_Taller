using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("Materias")]
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? Nombre { get; set; }

        [Required]        
        public int Semestre { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public virtual List<ProfesorPorMateria> ProfesorPorMateria { get; set; }
    }
}
