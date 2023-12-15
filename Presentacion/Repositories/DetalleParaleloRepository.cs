using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class DetalleParaleloRepository
    {

        private readonly AplicationDbContext _context;

        public DetalleParaleloRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar un nuevo detalle de paralelo
        public void AddDetalleParalelo(DetalleParalelo detalleParalelo)
        {
            _context.DetallesParalelos.Add(detalleParalelo);
            _context.SaveChanges();
        }

        // Método para actualizar un detalle de paralelo existente
        public void UpdateDetalleParalelo(DetalleParalelo detalleParalelo)
        {
            _context.DetallesParalelos.Update(detalleParalelo);
            _context.SaveChanges();
        }

        // Método para eliminar un detalle de paralelo por ID
        public void RemoveDetalleParalelo(int detalleParaleloId)
        {
            var detalleParalelo = _context.DetallesParalelos.Find(detalleParaleloId);

            if (detalleParalelo != null)
            {
                _context.DetallesParalelos.Remove(detalleParalelo);
                _context.SaveChanges();
            }
        }

        // Método para obtener todos los detalles de paralelos
        public List<DetalleParalelo> GetAllDetallesParalelos()
        {
            return _context.DetallesParalelos.ToList();
        }

        // Método para obtener un detalle de paralelo por ID
        public DetalleParalelo GetDetalleParaleloById(int detalleParaleloId)
        {
            return _context.DetallesParalelos.Find(detalleParaleloId);
        }

    }
}
