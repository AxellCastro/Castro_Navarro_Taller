using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class CalificacionRepository
    {

        private readonly AplicationDbContext _context;

        public CalificacionRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar una nueva calificación
        public void AddCalificacion(Calificacion calificacion)
        {
            _context.Calificaciones.Add(calificacion);
            _context.SaveChanges();
        }

        // Método para actualizar una calificación existente
        public void UpdateCalificacion(Calificacion calificacion)
        {
            _context.Calificaciones.Update(calificacion);
            _context.SaveChanges();
        }

        // Método para eliminar una calificación por ID
        public void RemoveCalificacion(int calificacionId)
        {
            var calificacion = _context.Calificaciones.Find(calificacionId);

            if (calificacion != null)
            {
                _context.Calificaciones.Remove(calificacion);
                _context.SaveChanges();
            }
        }

        // Método para obtener todas las calificaciones
        public List<Calificacion> GetAllCalificaciones()
        {
            return _context.Calificaciones.ToList();
        }

        // Método para obtener una calificación por ID
        public Calificacion GetCalificacionById(int calificacionId)
        {
            return _context.Calificaciones.Find(calificacionId);
        }

    }
}
