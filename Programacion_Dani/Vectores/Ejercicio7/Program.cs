/* (7) Crear un string con 100 letras entre la A y la Z de forma aleatoria. 
A continuación, calcular cuántas veces aparece cada letra en dicho string, y mostrar este resultado por pantalla, indicando la letra, y el número de veces que aparece.*/

using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        string letras = "";
        for (int i = 0; i < 100; i++)
        {
            char letra = (char)random.Next('A', 'Z' + 1);
            letras += letra;
        }

        Console.WriteLine("Esta es tu frase: " + letras);
        int[] contador = new int[26];
        for (int i = 0; i < letras.Length; i++)
        {
            char letra = letras[i];
            int indice = letra - 'A';
            contador[indice]++;
        }

        for (int i = 0; i < contador.Length; i++)
        {
            char letra = (char)('A' + i);
            Console.WriteLine($"{letra}: {contador[i]}");
        }
    }
}