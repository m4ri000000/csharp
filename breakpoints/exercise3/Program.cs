using System;

class Program
{
    static void Main()
    {
        int numero = 5;
        int resultado = Factorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {resultado}");
    }

    static int Factorial(int n)
    {
        if (n == 1)
        {
            // Coloca un breakpoint aquí para observar cuándo termina la recursión
            return 1;
        }
        // Coloca un breakpoint aquí para analizar cómo se acumula el resultado
        return n * Factorial(n - 1);
    }
}