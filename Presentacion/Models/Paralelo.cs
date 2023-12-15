using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("Paralelos")]
    public class Paralelo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string? Grupo { get; set; }

        [Required]
        [StringLength(255)]
        public string? Jornada { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
