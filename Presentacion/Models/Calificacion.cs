using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentación.Models
{
    [Table("Calificaciones")]
    public class Calificacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EstudiantesPorParaleloId { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal GF_P1 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal GP_P1 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal EXA_P1 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal PRO_P1 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal GF_P2 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal GP_P2 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal EXA_P2 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal PRO_P2 { get; set; }

        [Required]
        [Column(TypeName = "decimal(2,2)")]
        public decimal PRO_GEN { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public virtual EstudiantePorParalelo? EstudiantesPorParalelo { get; set; }
    }
}
