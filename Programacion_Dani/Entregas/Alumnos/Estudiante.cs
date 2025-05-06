using System.Runtime.CompilerServices;

namespace DanielDarias;

public class Estudiante : Persona, IComparable<Estudiante>
{
    private List<Calificacion> calificaciones = new List<Calificacion>();

    public void Calificar(string asignatura, float nota)
    {
        Calificacion c = new Calificacion(asignatura, nota);
        // While
        int i = 0;

        while (i < calificaciones.Count && calificaciones[i].Nota > c.Nota)
        {
            i++;
        }
        if(i < calificaciones.Count)
            calificaciones.Insert(i, c);
        else
            calificaciones.Add(c);
    }

    public int CompareTo(Estudiante? other)
    {
        if (other == null) return 1;
        return this.NotaMedia().CompareTo(other.NotaMedia());
    }

    public Estudiante(int e, long nDni, char IDni) : base(e, nDni, IDni)
    {
    }

    public Estudiante(string n, int e, long nDni, char IDni) : base(e, nDni, IDni, n)
    {
    }

    public float NotaMedia()
    {
        float media = 0;
        foreach (Calificacion c in calificaciones)
        {
            media += c.Nota;
        }
        return media / calificaciones.Count;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {NotaMedia().ToString("F2")}";
    }
}