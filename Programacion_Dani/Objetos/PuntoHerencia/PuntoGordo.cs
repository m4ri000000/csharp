using servicios.dig.cesarmanrique;

namespace mio;
public class PuntoGordo : Punto
{
    protected int _radio;
    public override int x
    {
        set
        {
            if (value >= MIN_X + _radio && value <= MAX_X - _radio)
                _x = value;
        }
    }
    public override int y
    {
        set
        {
            if (value >= MIN_Y + _radio && value <= MAX_Y - _radio)
                _y = value;
        }
    }
    public int r
    {
        get
        {
            return _radio;
        }
        set
        {

            if (value >= 0 &&
                _x - value >= MIN_X && _x + value <= MAX_X &&
                _y - value >= MIN_Y && _y + value <= MAX_Y)
                _radio = value;
        }
    }

    public PuntoGordo()
    {
        //_radio = 0;
    }
    public PuntoGordo(int x, int y, int r) : base(x, y)
    {
        // if(!( r>=0 &&
        //       x-r>=MIN_X && x+r <= MAX_X &&
        //       y-r>=MIN_Y && y+r <= MAX_Y ))
        if (r < 0 ||
            x - r < MIN_X || x + r > MAX_X ||
            y - r < MIN_Y || y + r > MAX_Y)
            throw new Exception();
    }

    public override float Distancia(Punto otro)
    {
        throw new Exception("Pendiente de implementar");
    }

    public override string ToString()
    {
        return $"({_x},{_y})";
    }
}