using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("Estudiantes")]
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Cedula { get; set; }

        [Required]
        [StringLength(255)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string? Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

    }
}
