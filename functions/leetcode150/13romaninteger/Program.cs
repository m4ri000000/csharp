using System;

public class RomanToInt
{
    public static int RomanToIntConverter(string s)
    {
        char[] simbolosRomanos = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        int[] valoresRomanos = { 1, 5, 10, 50, 100, 500, 1000 };
        int resultado = 0;
        int i;
        for (i = 0; i < s.Length; i++)
        {
            int valorActual = valoresRomanos[Array.IndexOf(simbolosRomanos, s[i])];
            if (i + 1 < s.Length)
            {
                int siguienteValor = valoresRomanos[Array.IndexOf(simbolosRomanos, s[i + 1])];
                if (valorActual < siguienteValor)
                {
                    resultado -= valorActual;
                }
                else
                {
                    resultado += valorActual;
                }
            }
            else
            {
                resultado += valorActual;
            }
        }

        return resultado;
    }

    public static void Main()
    {
        string numerosRomanos = "MDCCCLXXXVVIV";
        Console.WriteLine($"El numero romano {numerosRomanos} corresponde a {RomanToIntConverter(numerosRomanos)}.");
    }
}