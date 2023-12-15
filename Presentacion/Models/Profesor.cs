using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("Profesores")]
    public class Profesor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string? Apellido { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public virtual List<ProfesorPorMateria> ProfesorPorMateria { get; set; }
    }
}
