using System;
class Program
{
    static string ConvertirSegundos(int total)
    {
        int dias = total / (24 * 3600);
        total %= 24 * 3600;

        int horas = total / 3600;
        total %= 3600;

        int minutos = total / 60;
        int segundos = total % 60;

        return $"{dias} dia(s), {horas} horas, {minutos} minutos, {segundos} segundos";
    }

    static void Main(string[] args)
    {
        Console.WriteLine("inserir cantidad de segundos");
         int total = Convert.ToInt32(Console.ReadLine());

        string resultado = ConvertirSegundos(total);
        Console.WriteLine(resultado);
    }
}