using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class EstudianteRepository
    {

        private readonly AplicationDbContext _context;

        public EstudianteRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar un nuevo estudiante
        public void AddEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
        }

        // Método para actualizar un estudiante existente
        public void UpdateEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Update(estudiante);
            _context.SaveChanges();
        }

        // Método para eliminar un estudiante por ID
        public void RemoveEstudiante(int estudianteId)
        {
            var estudiante = _context.Estudiantes.Find(estudianteId);

            if (estudiante != null)
            {
                _context.Estudiantes.Remove(estudiante);
                _context.SaveChanges();
            }
        }

        // Método para obtener todos los estudiantes
        public List<Estudiante> GetAllEstudiantes()
        {
            return _context.Estudiantes.ToList();
        }

        // Método para obtener un estudiante por ID
        public Estudiante GetEstudianteById(int estudianteId)
        {
            return _context.Estudiantes.Find(estudianteId);
        }

    }

}
