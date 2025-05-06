using System;
using espacio_Producto;
namespace espacio_Articulo;
public class Articulo
{
    // Atributo público para el nombre del vendedor del articulo
    public string Vendedor;
    // Objeto Producto asociado al artículo (contiene código, nombre y precio base)
    public Producto Producto;
    // Atributo privado para el precio del artículo (puede diferir del precio base del producto)
    private decimal _Precio;
    // Propiedad pública para acceder y modificar el precio, con validación
    public decimal Precio
    {
        get { return _Precio; }
        set
        {
            // Valida que el precio no sea negativo
            if (value < 0)
                throw new Exception("No se puede poner un precio negativo");
            _Precio = value;
        }
    }
    // Constructor que inicializa el vendedor, el producto y el precio
    public Articulo(string v, string c, string n, string p)
    {
        Vendedor = v;
        Producto = new Producto(c, n);
        Precio = Convert.ToDecimal(p);
    }
    // Descripción del Articulo
    public override string ToString()
    {
        return $"Vendedor: {Vendedor} - Codigo del Producto: {Producto.Codigo} - Nombre del producto: {Producto.Nombre} - Precio: {Precio}";
    }
}