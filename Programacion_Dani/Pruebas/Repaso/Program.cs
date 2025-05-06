using System;

class Program
{
    static void Main(string[] args)
    {
        int dd, mm, aa;
        int dds, mms, aas;
        int dias = 0;
        Console.Write("Introduzca Día: ");
        dd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduzca Mes: ");
        mm = Int32.Parse(Console.ReadLine());
        Console.Write("Introduzca Año: ");
        aa = Convert.ToInt32(Console.ReadLine());
        if (comprueba(dd, mm, aa) == false)
        {
            Console.WriteLine("Fecha errónea");
            Console.ReadLine();
            return;
        }
        dds = dd + 1;
        mms = mm;
        aas = aa;
        switch (mm)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                dias = 31;
                break;
            case 2:
                if (bisiesto(aa))
                    dias = 29;
                else
                    dias = 28;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                dias = 30;
                break;
        }
        if (dds > dias)
        {
            dds = 1;
            if (mms == 12)
            {
                mms = 1;
                aas++;
            }
            else
                mms++;
        }
        Console.WriteLine("\n\n\n");
        Console.Write("Fecha: ");
        Console.Write("{0}/{1}/{2}", dds, mms, aas);
        Console.ReadLine();
    }

    static bool bisiesto(int aa)
    {
        if ((aa % 4 == 0) && (aa % 100 != 0) || (aa % 400 == 0))
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }

    static bool comprueba(int dd, int mm, int aa)
    {
        bool valor = true;
        int ddmax;
        if (mm < 1 || mm > 12)
        {
            valor = false;
        }
        else
        {
            if (mm == 2)
            {
                if (bisiesto(aa))
                {
                    ddmax = 29;
                }
                else
                {
                    ddmax = 28;
                }
            }
            else if ((mm == 4) || (mm == 6) || (mm == 9) || (mm == 11))
            {
                ddmax = 30;
            }
            else
            {
                ddmax = 31;
            }
            if (dd < 1 || dd > ddmax)
            {
                valor = false;
            }
        }
        return (valor);
    }
}