using System;

public class SecuenciaADN
{
    private char[] secuencia;

    public SecuenciaADN(string secuencia)
    {
        this.secuencia = secuencia.ToCharArray();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        SecuenciaADN otraSecuencia = (SecuenciaADN)obj;

        if (secuencia.Length != otraSecuencia.secuencia.Length)
            return false;

        string concatenada1 = new string(secuencia) + new string(secuencia);
        string concatenada2 = new string(otraSecuencia.secuencia);

        return concatenada1.Contains(concatenada2);
    }

    public override int GetHashCode()
    {
        return new string(secuencia).GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SecuenciaADN adn1 = new SecuenciaADN("TGCT");
        SecuenciaADN adn2 = new SecuenciaADN("GCTT");

        Console.WriteLine(adn1.Equals(adn2));
    }
}
