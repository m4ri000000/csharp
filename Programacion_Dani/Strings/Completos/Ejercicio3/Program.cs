/*(3) Escriba un programa para representar mediante barras de asteriscos 10 números 
recogidos por teclado con valores enteros entre 1 y 20. Los 10 números se introducen separados 
por un espacio mediante un string. 
Por ejemplo: 
Entrados los números: 
1 8 3 14 5 10 7 11 9 10 
el resultado es: 
1 * 
8 ******** 
3 *** 
14 ************** 
5 ***** 
10 ********** 
7 ******* 
11 *********** 
9 ********* 
10 ********** */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int lectura = 10;  // Sabemos que necesitamos 10 números
        int[] lista = new int[lectura];
        string numeros = Console.ReadLine();  // Lee la entrada como una cadena
        int j = 0;  // Índice para recorrer la cadena
        int i = 0;  // Índice para llenar el arreglo 'lista'

        // Mientras no hayamos recorrido todos los números
        while (i < lectura)
        {
            // Leer un número entero mientras no se alcanza la longitud de la cadena
            string numero = "";

            // Mientras no encontremos un espacio o hay caracteres disponibles
            while (j < numeros.Length && numeros[j] != ' ')
            {
                numero += numeros[j];  // Concatenamos los caracteres del número
                j++;
            }

            // Convertir el número y almacenarlo en la lista
            lista[i] = Convert.ToInt32(numero);
            i++;

            // Si encontramos un espacio, avanzamos el índice
            while (j < numeros.Length && numeros[j] == ' ')
            {
                j++;
            }
        }

        // Verificar si todos los números están en el rango de 1 a 20
        for (int w = 0; w < lectura; w++)
        {
            while (lista[w] < 1 || lista[w] > 20)
            {
                int nuevoNum;
                Console.WriteLine($"El número {lista[w]} no está en el intervalo de 1 a 20.");
                Console.Write("Introduce un nuevo número: ");
                nuevoNum = Convert.ToInt32(Console.ReadLine());
                if (nuevoNum >= 1 && nuevoNum <= 20)
                {
                    lista[w] = nuevoNum;
                }
                else
                {
                    Console.WriteLine("Número no válido. Inténtalo de nuevo.");
                }
            }
        }

        // Imprimir las barras de asteriscos
        for (int k = 0; k < lectura; k++)
        {
            // Imprimir el número de asteriscos correspondiente
            for (int l = 0; l < lista[k]; l++)
            {
                Console.Write("*");
            }
            Console.WriteLine();  // Salto de línea después de cada barra
        }
    }
}
