//ejercicio 3 modelo de examen
/*la idea es imprimir una tabla que muestre los valores:
AAAAAAO BBBBBOO CCCCOOO DDDOOOO EEOOOOO FOOOOOO*/
using System;
class Program
{
    static void Main()
    {
        int filas = 10; //numero total filas que voy a mostrar

        //creo un primer bucle externo que recorra las filas
        for (int i = 0; i < filas; i++) //i < filas establece el limite
        {
            //primer bucle interno, imprime letras repetidas
            for (int j = 0; j < filas - 1 - i; j++) 
            {
                Console.Write((char)('A' + i)); //(char) imprime los caracter en orden
            }
            //segundo bucle interno, imprime las O que rellenan los espacios sobrantes
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write('O');
            }

            Console.WriteLine(); //salto de linea al final de cada fila
        }
    }
}