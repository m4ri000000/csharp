/*(5) Escriba un programa que lea desde teclado valores para un vector con 20 números enteros 
positivos que representan las notas de alumnado (entre 0 y 10) y muestre por pantalla su 
contenido. A continuación, debe contar el número de alumn@s aproba@s y el número de 
alumn@s suspendid@s, así como la media de notas del grupo. 
Vector inicial: 5 4 3 5 2 9 6 8 10 3 5 6 4 2 4 9 7 3 4 7 
Número de aprobados: 11 
Número de suspendidos: 9  
Media del grupo: 5,30 */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int lectura = 20;
        int[] lista = new int[lectura];
        Console.Write("Introduce tus 10 números de UN digito: ");
        string numeros = Console.ReadLine();  // Lee la entrada como una cadena
        int j = 0;  // Índice para recorrer la cadena
        int i = 0;  // Índice para llenar el arreglo 'lista'
        int max = 10, min = 1;

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
            while (lista[w] < min || lista[w] > max)
            {
                int nuevoNum;
                Console.WriteLine($"El número {lista[w]} no está en el intervalo de 0 a 9.");
                Console.Write("Introduce un nuevo número: ");
                nuevoNum = Convert.ToInt32(Console.ReadLine());
                if (nuevoNum >= min && nuevoNum <= max)
                {
                    lista[w] = nuevoNum;
                }
                else
                {
                    Console.WriteLine("Número no válido. Inténtalo de nuevo.");
                }
            }
        }

        decimal media = 0, total = 0;

        // Bucle para sumar todos los valores
        for(int w = 0; w < lectura; w++){
            total += Convert.ToDecimal(lista[w]);
            // Console.WriteLine($"[LOG] {total} - {lista[w]}");
        }

        // Realizar la media
        media = total / lectura;

        Console.WriteLine($"La clase tiene una media de {media}");

    }
}