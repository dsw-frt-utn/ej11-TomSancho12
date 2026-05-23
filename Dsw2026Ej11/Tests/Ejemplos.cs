using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;
internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Juan Perez", 8.5);
        Alumno alumno2 = new Alumno(2, "Maria Garcia", 9.0);
        Alumno alumno3 = new Alumno(3, "Carlos Lopez", 7.5);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("=== Lista de alumnos ===");
        foreach (Alumno alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n=== Buscar alumno existente: Maria Garcia ===");
        Alumno encontrado = casoList.BuscarXNombre("Maria Garcia");
        Console.WriteLine(encontrado);

        Console.WriteLine("\n=== Buscar alumno no existente: Pedro Diaz ===");
        Alumno noEncontrado = casoList.BuscarXNombre("Pedro Diaz");
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n=== Eliminar a Carlos Lopez ===");
        casoList.EliminarAlumno(alumno3);
        foreach (Alumno alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n=== Eliminar el primer elemento (posicion 0) ===");
        casoList.EliminarAlumnoXPosicion(0);
        foreach (Alumno alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Juan Perez", 8.5);
        Alumno alumno2 = new Alumno(2, "Maria Garcia", 9.0);
        Alumno alumno3 = new Alumno(3, "Carlos Lopez", 7.5);

        casoDictionary.AgregarAlumno(alumno1);
        casoDictionary.AgregarAlumno(alumno2);
        casoDictionary.AgregarAlumno(alumno3);

        Console.WriteLine("=== Lista de alumnos ===");
        foreach (Alumno alumno in casoDictionary.ObtenerAlumnos().Values)
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n=== Buscar alumno con legajo 2 ===");
        Alumno encontrado = casoDictionary.BuscarAlumno(2);
        Console.WriteLine(encontrado);

        Console.WriteLine("\n=== Buscar alumno con legajo 99 ===");
        Alumno noEncontrado = casoDictionary.BuscarAlumno(99);
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n=== Eliminar alumno con legajo 1 ===");
        casoDictionary.EliminarAlumno(1);
        foreach (Alumno alumno in casoDictionary.ObtenerAlumnos().Values)
        {
            Console.WriteLine(alumno);
        }
    }

    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("=== Primer libro ===");
        Console.WriteLine(casoLinq.GetPrimero());

        Console.WriteLine("\n=== Último libro ===");
        Console.WriteLine(casoLinq.GetUltimo());

        Console.WriteLine("\n=== Suma de precios ===");
        Console.WriteLine($"Total: {casoLinq.GetTotalPrecios():C}");

        Console.WriteLine("\n=== Promedio de precios ===");
        Console.WriteLine($"Promedio: {casoLinq.GetPromedioPrecios():F2}");

        Console.WriteLine("\n=== Libros con Id mayor a 15 ===");
        foreach (Libro libro in casoLinq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n=== Títulos y precios ===");
        foreach (string libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n=== Libro con mayor precio ===");
        Console.WriteLine(casoLinq.GetMayorPrecio());

        Console.WriteLine("\n=== Libro con menor precio ===");
        Console.WriteLine(casoLinq.GetMenorPrecio());

        Console.WriteLine("\n=== Libros con precio mayor al promedio ===");
        foreach (Libro libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n=== Libros ordenados por título (descendente) ===");
        foreach (Libro libro in casoLinq.GetOrdenadosPorTitulo())
        {
            Console.WriteLine(libro);
        }
    }
}