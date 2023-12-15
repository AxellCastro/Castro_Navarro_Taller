using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class ProfesorPorMateriaRepository
    {

        private readonly AplicationDbContext _context;

        public ProfesorPorMateriaRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar un nuevo profesor por materia
        public void AddProfesorPorMateria(ProfesorPorMateria profesorPorMateria)
        {
            _context.ProfesoresPorMaterias.Add(profesorPorMateria);
            _context.SaveChanges();
        }

        // Método para actualizar un profesor por materia existente
        public void UpdateProfesorPorMateria(ProfesorPorMateria profesorPorMateria)
        {
            _context.ProfesoresPorMaterias.Update(profesorPorMateria);
            _context.SaveChanges();
        }

        // Método para eliminar un profesor por materia por ID
        public void RemoveProfesorPorMateria(int profesorPorMateriaId)
        {
            var profesorPorMateria = _context.ProfesoresPorMaterias.Find(profesorPorMateriaId);

            if (profesorPorMateria != null)
            {
                _context.ProfesoresPorMaterias.Remove(profesorPorMateria);
                _context.SaveChanges();
            }
        }

        // Método para obtener todos los profesores por materias
        public List<ProfesorPorMateria> GetAllProfesoresPorMaterias()
        {
            return _context.ProfesoresPorMaterias.ToList();
        }

        // Método para obtener un profesor por materia por ID
        public ProfesorPorMateria GetProfesorPorMateriaById(int profesorPorMateriaId)
        {
            return _context.ProfesoresPorMaterias.Find(profesorPorMateriaId);
        }

    }
}
