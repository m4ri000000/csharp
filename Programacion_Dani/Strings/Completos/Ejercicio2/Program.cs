/*(2) En España cada persona está identificada con un Documento Nacional de Identidad (DNI) en el que figura un número y una letra, por ejemplo 56999545W.
Crear un programa que calcule la letra de un DNI a partir de un número introducido por el usuario. El número se solicitará en una sola petición y se comprobará que cumple con el formato necesario (8 dígitos y una letra). El programa comprobará que lo introducido es un DNI correcto, calculando el valor de la letra y comprobando con lo introducido por el usuario.
Para calcular la letra, se debe tomar el resto de dividir nuestro número de DNI entre 23. El resultado debe estar por tanto entre 0 y 22. Este número refleja una posición del siguiente array de caracteres:
Posición     0   1   2   3  4   5   6  7  8  9  10  11  12  13  14  15  16  17  18  19  20  21  22
Letra            T   R  W A  G  M  Y  F  P  D  X    B   N    J    Z    S   Q    V   H    L   C   K   E

Por ejemplo, si introducimos el  DNI 20267079P, extraemos el número (20267079) y el resto de dividirlo por 23 sería 8. Mirando en la tabla dada, el elemento de la posición 8 es la P, se comprueba con lo introducido y vemos que el DNI es correcto.*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int digitos = 9, numeros = 0;
        char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        char letra;
        string? dni;

        Console.Write("Escribe los números de DNI: ");
        dni = Console.ReadLine();

        if (dni.Length != digitos)
        {
            Console.WriteLine("El número de DNI debe tener 8 dígitos.");
            return;
        }
        else
        {
            letra = dni[dni.Length - 1];
            // Console.WriteLine("[TEST] Letra " + letra);

            string auxiliar = "";
            for (int i = 0; i < dni.Length - 1; i++)
            {
                auxiliar += dni[i];
                numeros = Convert.ToInt32(auxiliar);
            }
            // Console.WriteLine("[TEST] Número " + numeros);
            int resultado = numeros % 23;

            if (resultado <= 22 && letra == letras[resultado])
            {
                Console.WriteLine("Correcto");
            }
            else
            {
                Console.WriteLine("Parece que los números introducidos no son correctos.");
            }
        }
    }
}