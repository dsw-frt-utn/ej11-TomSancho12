using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;
public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();
    public Libro GetPrimero()
    {
        return this.libros.First();
    }
    public Libro GetUltimo()
    {
        return this.libros.Last();
    }
    public decimal GetTotalPrecios()
    {
        return this.libros.Sum(libro => libro.Precio);
    }
    public double GetPromedioPrecios()
    {
        return (double)this.libros.Average(libro => libro.Precio);
    }
    public List<Libro> GetListById()
    {
        return this.libros.Where(libro => libro.Id > 15).ToList();
    }
    public List<string> GetLibros()
    {
        return this.libros.Select(libro => $"{libro.Titulo} - {libro.Precio:C}").ToList();
    }
    public Libro GetMayorPrecio()
    {
        return this.libros.OrderByDescending(libro => libro.Precio).First();
    }
    public Libro GetMenorPrecio()
    {
        return this.libros.OrderBy(libro => libro.Precio).First();
    }
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = this.libros.Average(libro => libro.Precio);
        return this.libros.Where(libro => libro.Precio > promedio).ToList();
    }
    public List<Libro> GetOrdenadosPorTitulo()
    {
        return this.libros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}
