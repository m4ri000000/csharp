using System;
namespace espacio_Producto;
public class Producto : IComparable<Producto>
{
    public string Codigo;
    public string Nombre;
    public decimal Precio;
    public Producto(string c, string n, string p)
    {
        Codigo = c;
        Nombre = n;
        Precio = Convert.ToDecimal(p);
    }
    public override bool Equals(object? otroProducto)
    {
        if (otroProducto == null || otroProducto.GetType() != GetType())
            return false;
        Producto otroPro = (Producto)otroProducto;
        return this.Codigo == otroPro.Codigo;
    }
    public override int GetHashCode()
    {
        return (Codigo).GetHashCode();
    }
    public int CompareTo(Producto? otroProducto)
    {
        if (otroProducto == null)
            return 1;
        return Nombre.CompareTo(otroProducto.Nombre);
    }
    public override string ToString()
    {
        return $"Código: {this.Codigo}, Nombre: {this.Nombre}";
    }
}