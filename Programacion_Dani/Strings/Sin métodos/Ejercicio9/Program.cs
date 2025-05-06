// (9) Dada una cadena de caracteres que contenga el nombre de una persona en formato APELLIDOS, NOMBRE, convertirla en una cadena del tipo NOMBRE APELLIDOS.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce tu Apellido y tu Nombre (Formato: APELLIDOS, NOMBRE): ");
        string? apellido_nombre = Console.ReadLine();

        int comaPos = -1;

        // Encontrar la posición de la coma
        for (int i = 0; i < apellido_nombre.Length && comaPos == -1; i++)
        {
            if (apellido_nombre[i] == ',')
            {
                comaPos = i;
            }
        }

        if (comaPos != -1)
        {
            // Apellido
            string apellidos = "";
            for (int i = 0; i < comaPos; i++)
            {
                apellidos += apellido_nombre[i];
            }

            // Nombre
            string nombre = "";
            for (int i = comaPos + 1; i < apellido_nombre.Length; i++)
            {
                nombre += apellido_nombre[i];
            }

            // Construir la nueva cadena
            string resultado = nombre + " " + apellidos;
            Console.WriteLine("Resultado: " + resultado);
        }
        else
        {
            Console.WriteLine("Formato incorrecto. Asegúrate de usar el formato: APELLIDOS, NOMBRE");
        }

    }
}