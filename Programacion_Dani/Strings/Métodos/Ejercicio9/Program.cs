/*(9) Un viajero quiere gestionar todos los gastos que hizo en su último viaje con la tarjeta de crédito, pero no sabe cuántos fueron, aunque sí tiene los tickets o facturas correspondientes. 
Estos gastos se pueden clasificar en cuatro tipos: comida, hospedaje, transporte y ropa. Escriba un programa que utilice vectores y permita al viajero determinar:
– Gastos totales discriminados por tipo.
– Cantidad de gastos que realizó en comida.
– Tipo de gasto en el que más invirtió dinero durante el viaje.*/

using System;
class Program
{
    static void Main(string[] args)
    {
        string[] tiposDeGasto = { "comida", "hospedaje", "transporte", "ropa" };
        double[] gastos = new double[4];
        int[] contadores = new int[4];

        Console.WriteLine("Ingrese los gastos en las diferentes categorías, escriba 'fin' para terminar.");

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Ingrese el tipo de gasto (comida, hospedaje, transporte, ropa): ");
            string tipoDeGasto = Console.ReadLine().ToLower();

            if (tipoDeGasto == "fin")
            {
                continuar = false;
                continue;
            }

            int indiceTipo = -1;
            for (int i = 0; i < tiposDeGasto.Length; i++)
            {
                if (tiposDeGasto[i].ToLower() == tipoDeGasto)
                {
                    indiceTipo = i;
                }
            }

            if (indiceTipo == -1)
            {
                Console.WriteLine("Tipo de gasto inválido, inténtelo de nuevo.");
                continue;
            }

            Console.WriteLine("Ingrese el monto del gasto: ");
            double monto;
            while (!double.TryParse(Console.ReadLine(), out monto) || monto < 0)
            {
                Console.WriteLine("Monto inválido, inténtelo de nuevo.");
            }

            gastos[indiceTipo] += monto;
            contadores[indiceTipo]++;
        }

        Console.WriteLine($"\nMontos de gastos por tipo:");
        for (int i = 0; i < gastos.Length; i++)
        {
            Console.WriteLine($"{tiposDeGasto[i]}: {gastos[i]}€");
        }

        Console.WriteLine($"\nCantidad de gastos en comida: {contadores[0]}");

        double gastoMaximo = gastos[0];
        string tipoMayorGasto = tiposDeGasto[0];

        for (int i = 1; i < gastos.Length; i++)
        {
            if (gastos[i] > gastoMaximo)
            {
                gastoMaximo = gastos[i];
                tipoMayorGasto = tiposDeGasto[i];
            }
        }

        Console.WriteLine($"\nEl tipo de gasto en el que más se invirtió es: {tipoMayorGasto} con un total de {gastoMaximo}€.");
    }
}
