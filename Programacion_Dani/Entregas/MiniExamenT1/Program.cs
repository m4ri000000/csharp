// solicite repetidamente la edad a una serie de personas. Seguirá pidiendo edades hasta que se le introduzca la (falsa) edad 999.
// El programa deberá calcular cuántas personas tienen entre 14 y 20 años y nos lo dirá… pero si dicho número termina en 3, en vez de mostrárnoslo, nos mostrará un mensaje que diga: ¡Qué casualidad!
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int edad, suma = 0;
        string texto = "¿Qué edad tienes? ";
        Console.Write(texto);
        edad = Convert.ToInt32(Console.ReadLine());

        while (edad != 999)
        {
            if (14 <= edad && edad <= 20)
            {
                suma++;
            }
            Console.Write(texto);
            edad = Convert.ToInt32(Console.ReadLine());
        }

        if((suma % 10) == 3){
            Console.WriteLine("¡Qué casualidad!");
        }else {
            Console.WriteLine("Hay un total de " + suma + " que tiene entre 18 y 24 años.");
        }
    }
}