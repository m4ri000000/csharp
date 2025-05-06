using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Prueba Ejercicio 1
        // char[] a = new char[]{'a', 'b', 'c', 'a'};
        // char[] b = new char[]{'b', 'a', 'b', 'c'};;
        // Console.WriteLine(Ejercicio1.Reproducir(a, b));

        // Prueba Ejercicio 2
        // double[] tiempos = new double[] { 1.50, 1.48, 2.06, 1.50, 1.69, 2.06, 1.88, 1.92 };
        // string[] nombres = new string[] { "Aitor", "Felisa", "Jonay", "Ester", "Ángela", "Tomás", "Óscar", "Taida" };
        // double[] penalizaciones = new double[] { 0.10, 0.20, 0.00, 0.00, 0.00, 0.04, 0.00, 0.60 };
        // double[] totales = new double[] { };

        // Console.WriteLine(Ejercicio2.Ganador(tiempos, nombres, penalizaciones, out totales));

        // Ejercicio 3
        double[] tiempos = new double[] { 1.50, 1.48, 2.06, 1.50, 1.69, 2.06, 1.88, 1.92 };
        string[] nombres = new string[] { "Aitor", "Felisa", "Jonay", "Ester", "Ángela", "Tomás", "Óscar", "Taida" };
        double[] penalizaciones = new double[] { 0.10, 0.20, 0.00, 0.00, 0.00, 0.04, 0.00, 0.60 };
        double[] totales = new double[] { };

        // for(int i = 0; i < tiempos.Length; i++){
        //      Console.WriteLine($"CHECK {tiempos[i]} {penalizaciones[i]}");
        // }
        Console.WriteLine($"GANADOR/A: {Ejercicio2.Ganador(tiempos, nombres, penalizaciones, out totales)}");

        if (totales != null)
        {
            Console.WriteLine("TOTALES:");
            for (int i = 0; i < totales.Length; i++)
            {
                Console.WriteLine($"{totales[i],4}");
            }
        }


    }
}

// Implementa la función Ejercicio1.Reproducir(...) que recibiendo dos tablas de igual 
// longitud con caracteres ‘a’, ‘b’ y ‘c’ genere una secuencia de caracteres, elegidos al azar de dichas 
// tablas y que los retorne sobre un dato de tipo String.
//  … String Reproducir(char[] a, char[] b) …
//  La secuencia generada se obtendrá añadiéndole los caracteres elegidos al azar de entre los 
// caracteres de ambas tablas para cada posición, al 50% de probabilidad.
//  ‘a’ ‘c’ ‘a’ ‘b’ ‘b’ ···
//  a  c  b  b  a  ···
//  ‘b’ ‘c’ ‘b’ ‘c’ ‘a’ ··
public class Ejercicio1
{
    public static string Reproducir(char[] a, char[] b)
    {
        string resultado = "";
        // Revisar que sean del mismo tamaño
        if (a.Length != b.Length)
        {
            resultado = "Valor invalido";
        }
        // Gen random
        Random random = new Random();

        // Escoger una tabla u otra
        for (int i = 0; i < a.Length; i++)
        {
            int probabilidad = random.Next(2);
            // Console.WriteLine($"TEST: {probabilidad}");
            if (probabilidad == 0)
            {
                resultado += a[i];
            }
            else
            {
                resultado += b[i];
            }
        }

        return resultado;
    }
}

// Implementa la función Ejercicio2.Ganador(...) . Recibirá como parámetros, tres tablas de datos de igual tamaño (de al menos tres datos) con los datos resultantes de una competición atlética y un cuarto parámetro para retornar una tabla nueva:
// - La primera, con datos de tipo double (tiempo en completar el recorrido).
// - La segunda, con datos de tipo String (nombres de los atletas).
// - La tercera, con datos de tipo double (penalización de tiempo por infracciones cometidas).
// - La cuarta, será para retornar una tabla con la suma de los tiempos más las penalizaciones.
// … String Ganador(double[] tiempos , String[] nombres , double[] penalizaciones, out double[] totales)
//  Cada elemento de las tablas corresponden a un competidor. La función retornará el nombre del ganador (solo el primero en caso de empate). 
// Para ello se habrá de sumar su tiempo más su penalización. El ganador será el que dé un valor menor

public class Ejercicio2
{
    public static string Ganador(double[] tiempos, string[] nombres, double[] penalizaciones, out double[] totales)
    {
        // Revisar que tengan el mismo tamaño y no sea menor a tres.
        if (tiempos.Length != nombres.Length || nombres.Length != penalizaciones.Length || tiempos.Length < 3)
        {
            totales = new double[0];
            return "Datos invalidos";
        }

        totales = new double[tiempos.Length];

        // Resolver los totales
        for (int i = 0; i < tiempos.Length; i++)
        {
            // Console.WriteLine($"CHECK DENTRO {totales[i]} {tiempos[i]} {penalizaciones[i]}");
            totales[i] = tiempos[i] + penalizaciones[i];

        }

        double minTiempo = totales[0];
        int indiceGanador = 0;

        // Alternativa al do-while
        // for (int i = 1; i < totales.Length; i++)
        // {
        //     if (totales[i] < minTiempo)
        //     {
        //         minTiempo = totales[i];
        //         indiceGanador = i;
        //     }
        // }

        // Sacar el nombre del corredor más rápido
        int j = 1;
        do
        {
            if (totales[j] < minTiempo)
            {
                minTiempo = totales[j];
                indiceGanador = j;
            }
            j++;
        } while (j < totales.Length);

        return nombres[indiceGanador];
    }
}