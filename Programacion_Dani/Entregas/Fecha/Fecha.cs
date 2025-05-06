public class Fecha
{

    private int Dia = 1;

    private int Mes = 12;

    private int[] DiasMes = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private static string[] NombreMes = new string[] { "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" };
    private int Año = 2023;
    public Fecha()
    {
        EsBisiesto();
    }

    public Fecha(int _Dia, int _Mes, int _Año)
    {
        EsValida(_Dia, _Mes, _Año);
        this.Dia = _Dia;
        this.Mes = _Mes;
        this.Año = _Año;
        EsBisiesto();
    }

    private void EsValida(int dia, int mes, int año)
    {
        if (año == 0)
        {
            throw new Exception("Año no válido");
        }

        else if (mes < 1 || mes > 12)
        {
            throw new Exception("Mes no válido");
        }
        else if (dia < 1 || dia > DiasMes[mes - 1])
        {
            throw new Exception("Día no válido");
        }
    }

    public void Incrementar()
    {
        EsBisiesto();
        if (Dia + 1 > DiasMes[Mes - 1])
        {
            if (Mes + 1 > 12)
            {
                Dia = 1;
                Mes = 1;
                Año++;
                EsBisiesto();
            }
            else
            {
                Mes++;
                Dia = 1;
            }
        }
        else
        {
            Dia++;
        }
    }

    public void Incrementar(int i)
    {
        if (i >= 0)
        {
            Dia += i;

            while (Dia > DiasMes[Mes - 1])
            {
                Dia -= DiasMes[Mes - 1];
                Mes++;
                if (Mes > 12)
                {
                    Mes = 1;
                    Año++;
                    EsBisiesto();
                }
            }
        }
        else
        {
            throw new Exception("Índice fuera de rango");
        }
    }

    public override bool Equals(object? f)
    {
        if (f == null || GetType() != f.GetType()) return false;
        Fecha OtraFecha = (Fecha)f;
        return this.Dia == OtraFecha.Dia && this.Mes == OtraFecha.Mes && this.Año == OtraFecha.Año;
    }

    private void EsBisiesto()
    {
        if ((Año % 4 == 0 && Año % 100 != 0) || (Año % 400 == 0))
        {
            DiasMes[1] = 28;
        }
        else
        {
            DiasMes[1] = 29;
        }
    }
    public override string ToString()
    {
        return $"{Dia:D2}-{NombreMes[Mes - 1]}-{Año:D4}";
    }
}