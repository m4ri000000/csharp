using System;

class Program
{
    static void Factoriza(int numero)
    {
        for (int i = 2; i <= numero; i++)
        {
            while (numero % i == 0)
            {
                Console.Write(i);
                numero /= i;
                if (numero > 1) Console.Write(" x ");
            }
        }
    }

    static void Main()
    {
        Console.Write("inserir numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{numero} = ");
        Factoriza(numero);
    }
}