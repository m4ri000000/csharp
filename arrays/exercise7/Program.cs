using System;
class Program
{
    static void Main()
    {
        Random random = new Random(); //
        char[] letras = new char [100];
        int[] conteo = new int [26];
        string resultado = new string(letras);
        int i;

        for (i = 0; i < 100; i++)
        {
            letras[i] = (char)random.Next('A', 'Z' + 1); //random next (inicio, fin)
            conteo[letras[i] - 'A']++;
        }

        for (i = 0; i < 100; i++)
        {
            Console.Write(letras[i] + " ");
            if ((i + 1) % 10 == 0) Console.WriteLine();
        }

        

        for (i = 0; i < 26; i++)
        {
            Console.WriteLine($"{(char)(i + 'A')}: {conteo[i]}");
        }

    }
}