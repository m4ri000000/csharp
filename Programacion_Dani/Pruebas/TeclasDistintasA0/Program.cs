using System;

class Program
{
    static void Main(string[] args)
    {
        int tecla, contador = 0;
        Console.WriteLine("Selecciona una tecla: ");
        tecla = Console.ReadKey().KeyChar;
        while (!(tecla == 46))
        {
            contador++;
            tecla = Console.ReadKey().KeyChar;
        }
        Console.WriteLine("El número de teclas distintas a 0 es: " + contador);
    }
}
