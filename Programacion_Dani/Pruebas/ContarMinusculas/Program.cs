using System;

class Program
{
    static void Main(string[] args)
    {
        char tecla;
        int contador = 0;
        Console.WriteLine("Selecciona una tecla: ");
        tecla = (char)Console.Read();
        while (tecla != 46)
        {
            tecla = Char.ToLower(tecla);
            if (tecla == 'a' || tecla == 'e' || tecla == 'i' || tecla == 'o' || tecla == 'u')
            {
                contador++;
                Console.WriteLine("TEQUE " + contador);
            }
            tecla = (char)Console.Read();

        }
        Console.WriteLine("El número de teclas distintas a 0 es: " + contador);
    }
}
