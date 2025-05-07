using System;
using System.IO;

interface IRegistrable
{
    void Guardar(string ruta);
    void Cargar(string ruta);
}

class EstacionClimatica : IRegistrable
{
    private string[] ciudades;
    private float[,,] temperaturas; // [ciudad, día, hora]

    public EstacionClimatica(string[] nombresCiudades, int dias, int horas)
    {
        ciudades = nombresCiudades;
        temperaturas = new float[ciudades.Length, dias, horas];

        Random rnd = new Random();
        for (int c = 0; c < ciudades.Length; c++)
        {
            for (int d = 0; d < dias; d++)
            {
                for (int h = 0; h < horas; h++)
                {
                    temperaturas[c, d, h] = rnd.Next(-5, 40) + (float)rnd.NextDouble();
                }
            }
        }
    }

    public void MostrarTemperaturas()
    {
        for (int c = 0; c < ciudades.Length; c++)
        {
            Console.WriteLine($"\nCiudad: {ciudades[c]}");
            for (int d = 0; d < temperaturas.GetLength(1); d++)
            {
                Console.Write($"Día {d + 1}: ");
                for (int h = 0; h < temperaturas.GetLength(2); h++)
                {
                    Console.Write($"{temperaturas[c, d, h]:0.0}°C ");
                }
                Console.WriteLine();
            }
        }
    }

    public void Guardar(string ruta)
    {
        using StreamWriter writer = new StreamWriter(ruta);
        for (int c = 0; c < ciudades.Length; c++)
        {
            for (int d = 0; d < temperaturas.GetLength(1); d++)
            {
                for (int h = 0; h < temperaturas.GetLength(2); h++)
                {
                    writer.WriteLine($"{ciudades[c]};{d + 1};{h}:00;{temperaturas[c, d, h]:0.0}");
                }
            }
        }
    }

    public void Cargar(string ruta)
    {
        if (!File.Exists(ruta))
        {
            Console.WriteLine("Archivo no encontrado.");
            return;
        }

        using StreamReader reader = new StreamReader(ruta);
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            var partes = line.Split(';');
            if (partes.Length != 4) continue;

            string ciudad = partes[0];
            int dia = int.Parse(partes[1]) - 1;
            int hora = int.Parse(partes[2].Split(':')[0]);
            float temp = float.Parse(partes[3]);

            int idx = Array.IndexOf(ciudades, ciudad);
            if (idx >= 0)
                temperaturas[idx, dia, hora] = temp;
        }
    }

    public float MediaCiudad(string ciudad)
    {
        int idx = Array.IndexOf(ciudades, ciudad);
        if (idx == -1) return float.NaN;

        float suma = 0;
        int total = 0;
        for (int d = 0; d < temperaturas.GetLength(1); d++)
        {
            for (int h = 0; h < temperaturas.GetLength(2); h++)
            {
                suma += temperaturas[idx, d, h];
                total++;
            }
        }
        return suma / total;
    }
}

class Program
{
    static void Main()
    {
        string[] ciudades = { "Madrid", "Valencia", "Sevilla" };
        EstacionClimatica estacion = new EstacionClimatica(ciudades, 3, 4); // 3 días, 4 horarios

        estacion.MostrarTemperaturas();

        Console.WriteLine("\nTemperatura media en Sevilla: " +
            estacion.MediaCiudad("Sevilla").ToString("0.0") + "°C");

        string ruta = "temperaturas.csv";
        estacion.Guardar(ruta);

        Console.WriteLine($"\nDatos guardados en: {ruta}");
    }
}