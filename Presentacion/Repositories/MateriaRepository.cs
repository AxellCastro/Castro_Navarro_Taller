using Presentación.Infrastructure;
using Presentación.Models;

namespace Presentación.Repositories
{
    public class MateriaRepository
    {

        private readonly AplicationDbContext _context;

        public MateriaRepository(AplicationDbContext context)
        {
            _context = context;
        }

        // Método para agregar una nueva materia
        public void AddMateria(Materia materia)
        {
            _context.Materias.Add(materia);
            _context.SaveChanges();
        }

        // Método para actualizar una materia existente
        public void UpdateMateria(Materia materia)
        {
            _context.Materias.Update(materia);
            _context.SaveChanges();
        }

        // Método para eliminar una materia por ID
        public void RemoveMateria(int materiaId)
        {
            var materia = _context.Materias.Find(materiaId);

            if (materia != null)
            {
                _context.Materias.Remove(materia);
                _context.SaveChanges();
            }
        }

        // Método para obtener todas las materias
        public List<Materia> GetAllMaterias()
        {
            return _context.Materias.ToList();
        }

        // Método para obtener una materia por ID
        public Materia GetMateriaById(int materiaId)
        {
            return _context.Materias.Find(materiaId);
        }

    }
}
