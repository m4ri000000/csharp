using System;
using System.IO;

class Ejercicio2
{
    static string ruta = "numeros.txt";
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("1. Crear el fichero");
            Console.WriteLine("2. Introducir valores");
            Console.WriteLine("3. Calcular máximo");
            Console.WriteLine("4. Calcular mínimo");
            Console.WriteLine("5. Calcular media");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: CrearFichero(); break;
                case 2: IntroducirValores(); break;
                case 3: MostrarValor(Math.Max); break;
                case 4: MostrarValor(Math.Min); break;
                case 5: CalcularMedia(); break;
            }
        } while (opcion != 0);
    }

    static void CrearFichero()
    {

        if (File.Exists(ruta))
        {
            Console.Write("El fichero ya existe, deseas sobrescribirlo? (s/n): ");
            if (Console.ReadLine().ToLower() != "s") return;
        }

        File.Create(ruta).Close();
        Console.WriteLine("Fichero creado.");
    }

    static void IntroducirValores()
    {
        using (Streamwriter sw = File.AppendText(ruta))
        {
            string entrada;
            do
            {
                Console.Write("ingrese un número (enter para terminar): ");
                entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int numero))
                {
                    sw.WriteLine(numero);
                }
            } while (!string.IsNullOrWhiteSpace(entrada));
        }
    }

    static void MostrarValor(Func<double, double, double> operacion){
        if (!File.Exists(ruta)) return;

        var nums = File.ReadAllLines(ruta)
                       .Where(1 => int.TryParse(1, out _))
                       .Select(int.Parse)
                       .ToArray();
        
        if (nums.Length == 0) return;

        double resultado = nums[0];
        foreach (int num in nums) {
            resultado = operacion (resultado, num);
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}