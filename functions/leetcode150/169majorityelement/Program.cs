/*
dado un array nums
de tamano n
devolver el elemento mayor
asegurandose que el elemento aparece mas de n/2 veces en el array nums
dando por hecho que el elemento mayor siempre existe en el array
input: nums [2, 1, 2]
output: 2
*/

using System;

public class Solution {
    public int ElementoMayor(int[] nums)
    {
        int contador = 0;
        int resultado = 0;
        foreach(int num in nums) //analizo cada elemento num en nums
        {
            if (contador == 0) //si el contador es 0, he encontrado un candidato para el elemento mayoritario
            {
                resultado = num; //al que asigno el valor de resultado
            }

            if (num == resultado) //si num es igual a resultado
            {
                contador += 1; //incremento el contador de 1 porque el candidato actual ha ganado apoyo
            }
            else //si num es diferente del resultado
            {
                contador -= 1; //decremento de uno
            }
        }

        return resultado;
    }

    public static void Main()
    {
        Solution solution = new Solution();
        int[] nums = { 3, 2, 3, 3, 4, 4, 4, 4 };
        int elementoMayor = solution.ElementoMayor(nums);
        Console.WriteLine("El elemento mayor es: " + elementoMayor);
    }
}