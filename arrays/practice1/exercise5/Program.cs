//solicita 10 numeros decimales, calcula media, y luego muestran los q estan por encima de la media
using System;
class Program
{
    static void Main()
    {
        decimal[] numeros = new decimal [10];
        //para media hace falta suma
        decimal suma = 0;
        int i;
        decimal media = 0;

        Console.WriteLine("escribe 10 numeros decimales: ");

        for (i = 0; i < 10; i++)
        {   
            Console.Write($"numero {i + 1}: ");
            numeros[i] = Convert.ToDecimal(Console.ReadLine());
            suma += numeros[i];
        }

        media = suma / 10;

        Console.WriteLine($"\nla media es {media}");
        Console.WriteLine("los numeros por encima de la media son");
        for (i = 0; i < 10; i++)
        {
            if (numeros[i] > media) 
            {
                Console.Write(numeros[i] + " ");
            }
        }

    }
}