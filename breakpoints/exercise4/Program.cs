using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                int producto = i * j;
                Console.WriteLine($"{i} x {j} = {producto}");
                // Coloca un breakpoint aquí para observar los valores de 'i', 'j' y 'producto'
            }
        }
    }
}
