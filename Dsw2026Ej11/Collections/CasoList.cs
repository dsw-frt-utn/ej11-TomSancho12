using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;
public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();
    public void AgregarAlumno(Alumno alumno)
    {
        this.alumnos.Add(alumno);
    }
    public List<Alumno> ObtenerAlumnos()
    {
        return this.alumnos;
    }
    public Alumno BuscarXNombre(string nombre)
    {
        foreach(Alumno alumno in this.alumnos)
        {
            if (alumno.Nombre == nombre)
            {
                return alumno;
            }
        }
        return null;
    }
    public void EliminarAlumno(Alumno alumno)
    {
        this.alumnos.Remove(alumno);
    }
    public void EliminarAlumnoXPosicion(int posicion)
    {
        if(posicion<0 || posicion >= this.alumnos.Count)
        {
            throw new ArgumentOutOfRangeException("posicion", "La posicion está fuera del rango de la lista.");
        }
        this.alumnos.RemoveAt(posicion);
    }
}
