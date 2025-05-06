using System;
using espacio_Producto;
namespace espacio_Articulo;
public class Articulo
{
    public string Vendedor;
    public Producto Producto;
    public decimal Precio;
    public Articulo(string v, string c, string n, string p)
    {
        Vendedor = v;
        Producto = new Producto(c, n, p);
        Precio = Convert.ToDecimal(p);
    }
    public override string ToString()
    {
        return $"Vendedor: {Vendedor} - Codigo del Producto: {Producto.Codigo} - Nombre del producto: {Producto.Nombre} - Precio: {Precio}";
    }
}