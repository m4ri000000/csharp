using System.Data.Common;

public class Punto
{
    public const int MAX_y = 25;
    public const int MAX_x = 80;
    private const int MIN_x = 1;
    private const int MIN_y = 1;
    private int _x = 1;
    private int _y = 1;

    public Punto(){}

    public Punto(int x, int y){
        this.x = x;
        this.y = y;
    }

    public int x
    {
        get
        {
            return _x;
        }
        set
        {
            if (value >= MIN_x && value <= MAX_x)
                _x = value;
        }
    }
    public int y
    {
        get
        {
            return _y;
        }
        set
        {
            if (value >= MIN_y && value <= MAX_y)
                _y = value;
        }
    }

    public float distancia(Punto otro)
    {
        int dx, dy;
        dx = _x - otro._x;
        dy = _y - otro._y;
        return (float)Math.Sqrt(dx * dx + dy * dy);
    }

    public void Mostrar(char a)
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(a);
    }

    public override string ToString()
    {
        return "(" + _x + "," + _y + ")";
    }
}