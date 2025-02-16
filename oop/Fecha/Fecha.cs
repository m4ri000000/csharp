using System;
public class Fecha
{
    private static string[] Meses = { "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" };
    private int dia;
    private int mes;
    private int anio;
    public Fecha()
    {
        this.dia = 1;
        this.mes = 1;
        this.anio = 1970;
    }
    public Fecha(int dia, int mes, int anio)
    {
        if (esValida(dia, mes, anio))
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }
    }
    public bool esValida(int dia, int mes, int anio)
    {
        if (mes < 1 || mes > 12) return false;
        if (dia < 1 || dia > DiasEnMes(mes, anio)) return false;
        return true;
    }

    private int DiasEnMes(int mes, int anio)
    {
        switch (mes)
        {
            case 2:
                return EsBisiesto(anio) ? 29 : 28;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            default:
                if (mes >= 1 && mes <= 12)
                {
                    return 31;
                }
                else
                {
                    throw new ArgumentException("mes no valido.");
                }
        }
    }

    public bool EsBisiesto(int anio)
    {
        return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
    }

    public void IncrementarDia()
    {
        dia++;
        if (dia > DiasEnMes(mes, anio))
        {
            dia = 1;
            mes++;
            if (mes > 12)
            {
                mes = 1;
                anio++;
            }
        }
    }

    public void IncrementarDias(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            IncrementarDia();
        }
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Fecha otraFecha = (Fecha)obj;
        return this.dia == otraFecha.dia &&
               this.mes == otraFecha.mes &&
               this.anio == otraFecha.anio;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(dia, mes, anio);
    }
    public int CompararCon(Fecha otraFecha)
    {
        if (this.anio != otraFecha.anio)
        {
            return this.anio.CompareTo(otraFecha.anio);
        }
        if (this.mes != otraFecha.mes)
        {
            return this.mes.CompareTo(otraFecha.mes);
        }
        return this.dia.CompareTo(otraFecha.dia);
    }
    public override string ToString()
    {
        return $"{dia:D2}-{Meses[mes - 1]}-{anio.ToString().Substring(2)}"; //IA
    }
}