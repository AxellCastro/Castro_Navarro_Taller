using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("DetalleParalelos")]
    public class DetalleParalelo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ParaleloId { get; set; }

        [Required]
        public int MateriaId { get; set; }

        [Required]
        public int ProfesorId { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public virtual Paralelo? Paralelo { get; set; }
        public virtual Materia? Materia { get; set; }
        public virtual Profesor? Profesor { get; set; }
    }
}
