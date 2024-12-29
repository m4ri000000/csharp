using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[4];
        double[,] sueldos = new double[4, 3];
        double[] ingresoAcumulado = new double[4];
        double totalSueldos = 0;
        string empleadoMayorIngreso = "";

        // Ingreso de datos
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Introduce el nombre del empleado {i + 1}: ");
            nombres[i] = Console.ReadLine();
            double sumaSueldos = 0;
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Introduce el sueldo de {nombres[i]} para el mes {j + 1}: ");
                sueldos[i, j] = Convert.ToDouble(Console.ReadLine());
                sumaSueldos += sueldos[i, j];
            }
            ingresoAcumulado[i] = sumaSueldos;
            totalSueldos += sumaSueldos;
        }

        // Mostrar el total de sueldos
        Console.WriteLine($"\nTotal de sueldos pagados: {totalSueldos}");

        // Obtener el empleado con mayor ingreso
        double maxIngreso = ingresoAcumulado[0];
        empleadoMayorIngreso = nombres[0];

        for (int i = 1; i < 4; i++)
        {
            if (ingresoAcumulado[i] > maxIngreso)
            {
                maxIngreso = ingresoAcumulado[i];
                empleadoMayorIngreso = nombres[i];
            }
        }

        Console.WriteLine($"El empleado con el mayor ingreso acumulado es: {empleadoMayorIngreso}");
    }
}