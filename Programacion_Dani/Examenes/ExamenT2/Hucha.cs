/* La clase Hucha debe tener las siguientes características:
•Un constructor por defecto que inicialice la hucha con 10 euros.
•Un constructor que permita inicializar la hucha con una cantidad específica.
•Métodos para Añadir y Sacar dinero.
•Un método para Vaciar completamente la hucha.
•Un método para consultar el saldo actual.
•Un método ToString() que muestre todos los movimientos y el saldo final.
•Un método Equals(...) que permita comparar Hucha y que las considere iguales si tienen el mismo*/

public class Hucha
{

    private decimal saldo;
    private List<Movimiento> movimientos = new List<Movimiento>();

    // Un constructor por defecto que inicialice la hucha con 10 euros.
    public Hucha()
    {
        saldo = 10;
    }

    // Un constructor que permita inicializar la hucha con una cantidad específica.
    public Hucha(decimal cantidadInicial) : this()
    {
        if (cantidadInicial < 0)
        {
            throw new Exception("El número introducido debe ser positivo.");
        }
        saldo = cantidadInicial;
    }


    // Métodos para Añadir y Sacar dinero.

    public void Añadir(decimal cantidad)
    {
        if (cantidad < 0)
        {
            RegistrarMovimiento("Operación anulada", -cantidad, saldo);
        }
        else
        {
            saldo += cantidad;
            RegistrarMovimiento("Añadido", cantidad, saldo);
        }

    }

    public void Sacar(decimal cantidad)
    {
        if ((saldo - cantidad) < 0)
        {

            RegistrarMovimiento("Operación anulada", cantidad, saldo);
        }
        else if (cantidad < 0)
        {
            RegistrarMovimiento("Operación anulada", -cantidad, saldo);
        }
        else
        {
            saldo -= cantidad;
            RegistrarMovimiento("Sacado", cantidad, saldo);
        }
    }

    // Un método para Vaciar completamente la hucha.

    public void Vaciar()
    {
        RegistrarMovimiento("Vaciado", saldo, 0);
        saldo = 0;

    }

    // Un método para consultar el saldo actual.
    public decimal Saldo()
    {
        return saldo;
    }

    // Un método ToString() que muestre todos los movimientos y el saldo final.
    public override string ToString()
    {
        return $"Saldo {saldo} \n{RegistroMovimientos()}";
    }

    // Un método Equals(...) que permita comparar Hucha y que las considere iguales si tienen el 0
    public override bool Equals(object? f)
    {
        if (f == null || GetType() != f.GetType()) return false;
        Hucha OtraHucha = (Hucha)f;
        return this.saldo == OtraHucha.saldo;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(saldo);
    }

    public void RegistrarMovimiento(string tipo, decimal cantidad, decimal saldoResultante)
    {
        Movimiento c = new Movimiento(tipo, cantidad, saldoResultante);
        movimientos.Add(c);

    }
    private string RegistroMovimientos()
    {
        string temp = "";
        foreach (Movimiento c in movimientos)
        {
            temp += c.ToString();
            temp += " \n ";
        }

        return temp;
    }

}