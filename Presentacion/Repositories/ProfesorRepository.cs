using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class ProfesorRepository
    {

        private readonly AplicationDbContext _context;

        public ProfesorRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar un nuevo profesor
        public void AddProfesor(Profesor profesor)
        {
            _context.Profesores.Add(profesor);
            _context.SaveChanges();
        }

        // Método para actualizar un profesor existente
        public void UpdateProfesor(Profesor profesor)
        {
            _context.Profesores.Update(profesor);
            _context.SaveChanges();
        }

        // Método para eliminar un profesor por ID
        public void RemoveProfesor(int profesorId)
        {
            var profesor = _context.Profesores.Find(profesorId);

            if (profesor != null)
            {
                _context.Profesores.Remove(profesor);
                _context.SaveChanges();
            }
        }

        // Método para obtener todos los profesores
        public List<Profesor> GetAllProfesores()
        {
            return _context.Profesores.ToList();
        }

        // Método para obtener un profesor por ID
        public Profesor GetProfesorById(int profesorId)
        {
            return _context.Profesores.Find(profesorId);
        }

    }
}
