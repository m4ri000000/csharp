using System;
class Program
{
    static void Main()
    {
        char[,] tabla = new char[7, 7]; //tabla bidimensional 7x7
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (j < 7 - i - 1)
                {
                    tabla[i, j] = (char)('A' + j);
                }
                else
                {
                    tabla[i, j] = 'O';
                }
            }
        }

        //tabla
        for (int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                Console.Write(tabla[i, j] + " ");
            }
            Console.WriteLine();
        }

        //contenido
        Console.WriteLine("\ncontenido de la tabla: ");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(tabla[j, i]);
            }
            Console.WriteLine();
        }
    }
}