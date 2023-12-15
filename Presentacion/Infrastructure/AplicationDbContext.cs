using Microsoft.EntityFrameworkCore;
using Presentación.Models;

namespace Presentación.Infrastructure
{
    public class AplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-RGRGUHEM\SQLEXPRESS;Database=BD_TALLER_2;Trusted_Connection=True;Encrypt=False;");
        }

        public DbSet<Calificacion> Calificaciones { get; set; }

        public DbSet<DetalleParalelo> DetallesParalelos { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<EstudiantePorParalelo> EstudiantesPorParalelos { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Paralelo> Paralelos { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<ProfesorPorMateria> ProfesoresPorMaterias { get; set; }        

    }
}
