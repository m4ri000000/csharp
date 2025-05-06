using System;
class Program
{
    static int[] ConvertirDias(int total)
    {
        int anios = total / 365;
        int diasRest = total % 365;

        int meses = diasRest / 30;
        int diasRestTrasMeses = diasRest % 30;

        int semanas = diasRestTrasMeses / 7;
        int diasFinales = diasRestTrasMeses % 7;

        return new int[4] { anios, meses, semanas, diasFinales};
    }

    static void Main()
    {
        Console.Write("escribe una cantidad de dias: ");
        int total = Convert.ToInt32(Console.ReadLine());

        int[] tiempo = ConvertirDias(total);

        Console.WriteLine($"{tiempo[0]} años, {tiempo[1]} meses, {tiempo[2]} semanas, {tiempo[3]} dia(s)");
    }
}