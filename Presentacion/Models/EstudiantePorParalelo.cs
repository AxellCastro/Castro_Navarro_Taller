using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("EstudiantesPorParalelos")]
    public class EstudiantePorParalelo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DetalleParaleloId { get; set; }

        [Required]
        public int EstudianteId { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public virtual DetalleParalelo DetalleParalelo { get; set; }

        public virtual Estudiante Estudiante { get; set; }
    }
}
