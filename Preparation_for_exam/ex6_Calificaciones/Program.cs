using System;
using System.Collections.Generic;
using System.IO;

public class Alumno : IComparable<Alumno>
{
    public string DNI { get; set; }
    public string Nombre { get; set; }

    public Alumno(string dni, string nombre)
    {
        DNI = dni;
        Nombre = nombre;
    }

    public override bool Equals(object obj) => obj is Alumno a && a.DNI == DNI;
    public override int GetHashCode() => DNI.GetHashCode();
    public int CompareTo(Alumno other) => Nombre.CompareTo(other?.Nombre);
    public override string ToString() => $"{Nombre} ({DNI})";
}

public class Nota
{
    public Alumno Alumno { get; set; }
    public string Curso { get; set; }       // Ej: "1º ESO"
    public string Asignatura { get; set; }  // Ej: "Matemáticas"
    public double Calificacion { get; set; }

    public Nota(Alumno alumno, string curso, string asignatura, double calificacion)
    {
        Alumno = alumno;
        Curso = curso;
        Asignatura = asignatura;
        Calificacion = calificacion;
    }

    public override string ToString() => $"{Alumno.Nombre} - {Curso} - {Asignatura}: {Calificacion:F1}";
}

public class RegistroNotas
{
    private List<Nota> notas = new List<Nota>();

    public RegistroNotas(string rutaCSV)
    {
        var lineas = File.ReadAllLines(rutaCSV);
        foreach (var linea in lineas)
        {
            var datos = linea.Split(';');
            if (datos.Length == 5)
            {
                var dni = datos[0];
                var nombre = datos[1];
                var curso = datos[2];
                var asignatura = datos[3];
                var nota = double.Parse(datos[4]);

                var alumno = new Alumno(dni, nombre);
                notas.Add(new Nota(alumno, curso, asignatura, nota));
            }
        }
    }

    public void GuardarCSV(string ruta)
    {
        using (StreamWriter writer = new StreamWriter(ruta))
        {
            foreach (var nota in notas)
            {
                writer.WriteLine($"{nota.Alumno.DNI};{nota.Alumno.Nombre};{nota.Curso};{nota.Asignatura};{nota.Calificacion}");
            }
        }
    }

    public void AñadirNota(string dni, string nombre, string curso, string asignatura, double nota)
    {
        var alumno = new Alumno(dni, nombre);
        notas.Add(new Nota(alumno, curso, asignatura, nota));
    }

    public void ModificarNota(string dni, string asignatura, double nuevaNota)
    {
        foreach (var n in notas)
        {
            if (n.Alumno.DNI == dni && n.Asignatura == asignatura)
            {
                n.Calificacion = nuevaNota;
                return;
            }
        }
    }

    public string ListarNotasDeAlumno(string dni)
    {
        List<string> resultado = new List<string>();
        foreach (var nota in notas)
        {
            if (nota.Alumno.DNI == dni)
            {
                resultado.Add($"{nota.Asignatura} ({nota.Curso}): {nota.Calificacion:F1}");
            }
        }

        if (resultado.Count == 0)
            return "No se encontraron notas.";

        return $"=== Notas del alumno {dni} ===\n" + string.Join("\n", resultado);
    }

    public override string ToString()
    {
        List<string> resultado = new List<string> { "=== Registro de Notas ===" };
        List<Nota> ordenadas = new List<Nota>(notas);
        ordenadas.Sort((a, b) => a.Alumno.CompareTo(b.Alumno));
        foreach (var nota in ordenadas)
        {
            resultado.Add(nota.ToString());
        }
        return string.Join("\n", resultado);
    }
}

class Program
{
    static void Main()
    {
        RegistroNotas registro = new RegistroNotas("notas.csv");

        registro.AñadirNota("12345678A", "Laura Ruiz", "2º ESO", "Lengua", 7.5);
        registro.ModificarNota("12345678A", "Lengua", 8.2);

        Console.WriteLine(registro.ListarNotasDeAlumno("12345678A"));
        Console.WriteLine(registro);

        registro.GuardarCSV("notas_actualizadas.csv");
    }
}