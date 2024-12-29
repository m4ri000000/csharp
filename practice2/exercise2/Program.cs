/*(2)	Realizar el mismo ejercicio anterior, pero al pasar a la función los grados Celcius, 
también se le pasará una “F” para pasar a grados Fahrenheit, 
o una “K” para pasar a grados Kelvin. */
using System;
class Program
{
    static void ContadorDeLetras(string cadena, char letra, out int contador)
    {
        contador = 0; //inicializo el contador en 0 
        int i; //declaro la var i para mi bucle for
        for (i = 0; i < cadena.Length; i++) //empiezo un bucle for que recorra todos los caracteres del string
        {
            if(cadena[i] == letra) //scanner, en cada iteracion analiza si el caracter es igual a la letra que estamos buscando
            {
                contador++; //si lo es, el contador aumenta de 1 
            }
        }
    }

    static void Main()
    {
        Console.Write("inserir cadena: ");
        string cadena = Console.ReadLine();
        Console.Write("letra a buscar: ");
        char letra = Console.ReadLine()[0]; //ese [0] es para convertir de string a char
        int contador;
        ContadorDeLetras(cadena, letra, out contador);
        Console.WriteLine($"La letra {letra} aparece {contador} veces en la frase '{cadena}'.");
    }
}