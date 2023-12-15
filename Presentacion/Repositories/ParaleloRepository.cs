using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class ParaleloRepository
    {

        private readonly AplicationDbContext _context;

        public ParaleloRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar un nuevo paralelo
        public void AddParalelo(Paralelo paralelo)
        {
            _context.Paralelos.Add(paralelo);
            _context.SaveChanges();
        }

        // Método para actualizar un paralelo existente
        public void UpdateParalelo(Paralelo paralelo)
        {
            _context.Paralelos.Update(paralelo);
            _context.SaveChanges();
        }

        // Método para eliminar un paralelo por ID
        public void RemoveParalelo(int paraleloId)
        {
            var paralelo = _context.Paralelos.Find(paraleloId);

            if (paralelo != null)
            {
                _context.Paralelos.Remove(paralelo);
                _context.SaveChanges();
            }
        }

        // Método para obtener todos los paralelos
        public List<Paralelo> GetAllParalelos()
        {
            return _context.Paralelos.ToList();
        }

        // Método para obtener un paralelo por ID
        public Paralelo GetParaleloById(int paraleloId)
        {
            return _context.Paralelos.Find(paraleloId);
        }

    }
}
