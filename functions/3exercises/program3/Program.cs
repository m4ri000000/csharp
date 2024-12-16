//funcion que busque elemento
using System;
class Program
{
    static int BuscarElemento(double[] array, double valor)
    {
        int pos = 0;
        for (pos = 0; pos < array.Length; pos++)
        {
            if(array[pos] == valor)
            {
                return pos;
            }
        }
        return -1;
    }
}