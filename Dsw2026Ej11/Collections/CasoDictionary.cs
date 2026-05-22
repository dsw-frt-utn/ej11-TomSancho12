using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        this.alumnos.Add(alumno.Id, alumno);
    }
    public Alumno BuscarAlumno(int legajo)
    {
        if (this.alumnos.ContainsKey(legajo))
        {
            return this.alumnos[legajo];
        }
        return null;
    }
    public Dictionary<int, Alumno> ObtenerAlumnos()
    {
        return this.alumnos;
    }
    public void EliminarAlumno(int legajo)
    {
        if (this.alumnos.ContainsKey(legajo))
        {
            this.alumnos.Remove(legajo);
        }
        else
        {
            throw new ArgumentException("No existe un alumno con el legajo indicado.", "legajo");
        }
    }
}
