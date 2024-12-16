using System;
using System.Data;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("introduce el numerador: ");
            int numerador = Convert.ToInt32(Console.ReadLine());

            Console.Write("introduce el denominador: ");
            int denominador = Convert.ToInt32(Console.ReadLine());

            int resultado = numerador / denominador;
            Console.WriteLine($"el resultado es {resultado}.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(" " + ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(" " + ex);
        }
        finally
        {
            Console.WriteLine("operacion realizada.");
        }
    }
}