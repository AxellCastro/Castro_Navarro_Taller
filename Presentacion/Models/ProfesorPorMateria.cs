using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("ProfesoresPorMaterias")]
    public class ProfesorPorMateria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MateriaId { get; set; }

        [Required]
        public int ProfesorId { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public virtual Materia? Materia { get; set; }
        public virtual Profesor? Profesor { get; set; }
    }
}
