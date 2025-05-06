// (6) Recogidos los datos del nombre de diez alumnos, y la nota que han obtenido en un examen, calcular la media de las notas de los diez alumnos, e indicar el nombre de los alumnos que tienen una nota inferior a la media.

using System;

public class Program
{
    public static void Main()
    {
        decimal suma = 0;
        int max = 10;
        string[] nombres = new string[max];
        decimal[] notas = new decimal[max];

        for (int i = 0; i < max; i++)
        {
            Console.Write("Introduce el nombre del alumno: ");
            nombres[i] = Console.ReadLine();
            Console.Write("Introduce la nota del alumno: ");
            notas[i] = Convert.ToDecimal(Console.ReadLine());
            suma += notas[i];
        }

        decimal resultado = suma / max;
        Console.WriteLine($"La media es: {resultado}");

        Console.WriteLine("Alumnos con nota inferior a la media:");
        for (int i = 0; i < max; i++)
        {
            if (notas[i] < resultado)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}