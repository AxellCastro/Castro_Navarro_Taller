using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class EstudiantePorParaleloRepository
    {

        private readonly AplicationDbContext _context;

        public EstudiantePorParaleloRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar un nuevo estudiante por paralelo
        public void AddEstudiantePorParalelo(EstudiantePorParalelo estudiantePorParalelo)
        {
            _context.EstudiantesPorParalelos.Add(estudiantePorParalelo);
            _context.SaveChanges();
        }

        // Método para actualizar un estudiante por paralelo existente
        public void UpdateEstudiantePorParalelo(EstudiantePorParalelo estudiantePorParalelo)
        {
            _context.EstudiantesPorParalelos.Update(estudiantePorParalelo);
            _context.SaveChanges();
        }

        // Método para eliminar un estudiante por paralelo por ID
        public void RemoveEstudiantePorParalelo(int estudiantePorParaleloId)
        {
            var estudiantePorParalelo = _context.EstudiantesPorParalelos.Find(estudiantePorParaleloId);

            if (estudiantePorParalelo != null)
            {
                _context.EstudiantesPorParalelos.Remove(estudiantePorParalelo);
                _context.SaveChanges();
            }
        }

        // Método para obtener todos los estudiantes por paralelos
        public List<EstudiantePorParalelo> GetAllEstudiantesPorParalelos()
        {
            return _context.EstudiantesPorParalelos.ToList();
        }

        // Método para obtener un estudiante por paralelo por ID
        public EstudiantePorParalelo GetEstudiantePorParaleloById(int estudiantePorParaleloId)
        {
            return _context.EstudiantesPorParalelos.Find(estudiantePorParaleloId);
        }

    }
}
