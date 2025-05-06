/*(8) Se tiene la siguiente información:
Nombres de 4 empleados.
Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.
Realizar un programa para:

Realizar el ingreso de la información mencionada. 
Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada operario.
Mostrar por pantalla el total pagado en sueldos a todos los operarios en los últimos 3 meses 
Obtener el nombre del operario que tuvo el mayor ingreso acumulado.
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numOperarios = 4;
        int numMeses = 3;
        string[] operarios = new string[numOperarios];
        decimal[,] sueldos = new decimal[numOperarios, numMeses];
        decimal[] ingresosAcumulados = new decimal[numOperarios];

        // Obtener los nombres y sueldos de los operarios
        for (int i = 0; i < numOperarios; i++)
        {
            Console.Write("Introduce el nombre del operario: ");
            operarios[i] = Console.ReadLine() ?? string.Empty;

            for (int j = 0; j < numMeses; j++)
            {
                Console.Write($"Introduce el sueldo del operario en el mes {j + 1}: ");
                while (!decimal.TryParse(Console.ReadLine(), out sueldos[i, j]))
                {
                    Console.Write("Entrada no válida. Introduce un número: ");
                }
                ingresosAcumulados[i] += sueldos[i, j];
            }
        }

        // Determinar el operario con el mayor ingreso acumulado
        decimal mayorIngreso = ingresosAcumulados[0];
        string operarioMayorIngreso = operarios[0];

        for (int i = 1; i < numOperarios; i++)
        {
            if (ingresosAcumulados[i] > mayorIngreso)
            {
                mayorIngreso = ingresosAcumulados[i];
                operarioMayorIngreso = operarios[i];
            }
        }

        // Mostrar los resultados
        for (int i = 0; i < numOperarios; i++)
        {
            Console.WriteLine($"Operario: {operarios[i]}");
            for (int j = 0; j < numMeses; j++)
            {
                Console.WriteLine($"  Mes {j + 1}: {sueldos[i, j]}");
            }
            Console.WriteLine($"  Ingreso acumulado: {ingresosAcumulados[i]}");
        }

        Console.WriteLine($"\nEl operario con el mayor ingreso acumulado es: {operarioMayorIngreso} con un ingreso de {mayorIngreso}");
    }
}