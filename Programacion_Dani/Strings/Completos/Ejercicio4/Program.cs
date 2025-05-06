/*(4) Escriba un programa que lea 10 números enteros positivos de una cifra y los coloque 
dentro de un vector. A continuación lea un nuevo número entero positivo de una cifra. 
Finalmente, creamos un nuevo vector en el que, si la cifra a tratar es mayor que el número dado, 
introduce el número, y si la cifra es menor o igual que el número dado, introduce un cero. 
Muestre el vector resultante. 
Por ejemplo: 
Entrados los números: 2 2 5 1 5 8 4 2 3 9 
Valor a buscar: 3 
el resultado es: 
2 2 5 1 5 8 4 2 3 9 
0 0 5 0 5 8 4 0 0 9 */

using System;

public class Program
{
    public static void Main(String[] args)
    {
        int lectura = 10;
        int[] lista = new int[lectura];
        Console.Write("Introduce tus 10 números de UN digito: ");
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
            while (lista[w] < -1 || lista[w] > 10)
            {
                int nuevoNum;
                Console.WriteLine($"El número {lista[w]} no está en el intervalo de 0 a 9.");
                Console.Write("Introduce un nuevo número: ");
                nuevoNum = Convert.ToInt32(Console.ReadLine());
                if (nuevoNum >= 0 && nuevoNum <= 9)
                {
                    lista[w] = nuevoNum;
                }
                else
                {
                    Console.WriteLine("Número no válido. Inténtalo de nuevo.");
                }
            }
        }

        // Segundo número
        int cifra;
        Console.Write("Introduce tu número: ");
        cifra = Convert.ToInt32(Console.ReadLine());

        // Imprimir nueva cadena
        for (int w = 0; w < lectura; w++)
        {
            // Imprimir número si es menor
            if (cifra < lista[w])
            {
                Console.Write($"{lista[w]} ");
            }
            // Imprimir 0 si es menor o igual
            else
            {
                Console.Write("0 ");
            }
        }

    }
}