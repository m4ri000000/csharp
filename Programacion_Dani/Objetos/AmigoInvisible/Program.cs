using System;
public class Program
{
    public static void Main()
    {
        int participantes = 10;
        ListaDeAsignaciones asignaciones = new ListaDeAsignaciones(participantes);
        
        // Generar las asignaciones aleatorias
        asignaciones.GeneraAsignaciones();

        // Mostrar el resultado
        Console.WriteLine(asignaciones.ToString());
    }
}