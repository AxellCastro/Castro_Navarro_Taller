using Microsoft.EntityFrameworkCore;
using Presentación.Infrastructure;
/*
using (var context = new AplicationDbContext())
{
    Console.WriteLine("Consulta: Obtener Profesores con Materias");

    var profesoresConMaterias = context.Profesores
        .Include(p => p.ProfesorPorMateria)
            .ThenInclude(ppm => ppm.Materia)
        .ToList();

    foreach (var profesor in profesoresConMaterias)
    {
        Console.WriteLine($"Profesor: {profesor.Nombre} {profesor.Apellido}");

        foreach (var profesorPorMateria in profesor.ProfesorPorMateria)
        {
            Console.WriteLine($"  Materia: {profesorPorMateria.Materia.Nombre}");
        }

        Console.WriteLine();
    }
}

using (var context = new AplicationDbContext())
{
    Console.WriteLine("Consulta: Obtener Estudiantes con Paralelos y Materias");

    var estudiantesConParalelosYMaterias = context.EstudiantesPorParalelos
        .Include(epp => epp.Estudiante)
        .Include(epp => epp.DetalleParalelo)
            .ThenInclude(dp => dp.Paralelo)
        .Include(epp => epp.DetalleParalelo)
            .ThenInclude(dp => dp.Materia)
        .ToList();

    foreach (var estudiantePorParalelo in estudiantesConParalelosYMaterias)
    {
        Console.WriteLine($"Estudiante: {estudiantePorParalelo.Estudiante.Nombre} {
            estudiantePorParalelo.Estudiante.Apellido}");

        if (estudiantePorParalelo.DetalleParalelo != null)
        {
            Console.WriteLine($"  Paralelo: {estudiantePorParalelo.DetalleParalelo.Paralelo.Nombre}");
            Console.WriteLine($"  Materia: {estudiantePorParalelo.DetalleParalelo.Materia.Nombre}");
        }
        else
        {
            Console.WriteLine("  Sin información de paralelo y materia.");
        }

        Console.WriteLine();
    }
}
*/






using (var context = new AplicationDbContext())
{
    Console.WriteLine("Consulta: Obtener Estudiante por Id con Detalles de Paralelo y Paralelo");

    int estudianteId = 6; 

    var estudianteConDetallesYParalelo = context.EstudiantesPorParalelos
        .Where(epp => epp.Id == estudianteId)
        .Include(epp => epp.Estudiante)
        .Include(epp => epp.DetalleParalelo)
            .ThenInclude(dp => dp.Paralelo)
        .FirstOrDefault();

    if (estudianteConDetallesYParalelo != null)
    {
        Console.WriteLine($"Estudiante: {estudianteConDetallesYParalelo.Estudiante.Nombre} " +
            $"{estudianteConDetallesYParalelo.Estudiante.Apellido}");

        if (estudianteConDetallesYParalelo.DetalleParalelo != null)
        {
            Console.WriteLine($"  Detalle de Paralelo: " +
                $"{estudianteConDetallesYParalelo.DetalleParalelo.Id}");
            Console.WriteLine($"    Paralelo: " +
                $"{estudianteConDetallesYParalelo.DetalleParalelo.Paralelo.Nombre}");
        }
        else
        {
            Console.WriteLine("  Sin información de detalle de paralelo y paralelo.");
        }
    }
    else
    {
        Console.WriteLine($"No se encontró un estudiante con Id {estudianteId}.");
    }
}
