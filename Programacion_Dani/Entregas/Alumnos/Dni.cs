namespace DanielDarias;

public class DNI
{
    private char _ldni;
    private long _ndni;

    public char lDni
    {
        get
        {
            return _ldni;
        }
    }

    public long nDni
    {
        get
        {
            return _ndni;
        }
    }

    public DNI()
    {
        _ndni = 0;
        _ldni = ' ';
    }
    public DNI(long num, char l):this()
    {
        _ndni = num;
        if (LetraValida(num) == l)
            _ldni = Char.ToUpper(l);
        else
            throw new System.ArgumentException("Letra no válida");
    }

    public override bool Equals(object? f)
    {
        if (f == null || GetType() != f.GetType()) return false;
        DNI OtroDNI = (DNI)f;
        return this.lDni == OtroDNI.lDni && this.nDni == OtroDNI.nDni;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(lDni, nDni);
    }


    private char LetraValida(long n)
    {
        char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        return letras[n % 23];
    }

    public override string ToString()
    {
        return $"{nDni}{lDni}";
    }

}