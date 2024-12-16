using System;
class Program
{
    static void Main()
    {
        string[] nombres = new string[10];
        int[] notas = new int[10];
        //PARA LA MEDIA HACE FALTA SUMA
        int suma = 0;
        int media = 0;
        int i;

        Console.WriteLine("introduce el nombre y la nota de 10 alumnos");
        for (i = 0; i < 10; i++)
        {
            Console.Write($"nombre del alumno numero {i + 1}: ");
            nombres[i] = Console.ReadLine();

            Console.Write($"nota del alumno {i + 1}: ");
            notas[i] = Convert.ToInt32(Console.ReadLine());

            suma += notas[i];
        }

        media = suma / 10;
        Console.WriteLine($"la media es {media}");

        Console.WriteLine("los alumnos con nota por debajo de la media son: ");
        for (i = 0; i < 10; i++)
        {
            if (notas[i] < media)
            {
                Console.Write(nombres[i] + " ");
            }
        }
    }
}