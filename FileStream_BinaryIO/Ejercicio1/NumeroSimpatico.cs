using System;
public class NumeroSimpatico
{
    private int estado = 0;
    public void addDigito(int dig)
    {
        if (estado == 0)
        {
            if (dig == 6 || dig == 7 || dig == 8)
                estado = 2;
            else if (dig == 2 || dig == 3 || dig == 9)
                estado = 1;
        }
        else if (estado == 1)
        {
            if (dig % 2 == 1)
                estado = 0;
        }
        else if (estado == 2)
        {
            if (dig < 5)
                estado = 0;
            else if (dig > 5)
                estado = 1;
        }
    }
    public bool isValido()
    {
        return estado == 0;
    }
}