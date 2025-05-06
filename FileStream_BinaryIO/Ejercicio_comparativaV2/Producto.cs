using System;
namespace espacio_Producto;
public class Producto : IComparable<Producto>
{
    // Atributo público para el código del producto
    public string Codigo;
    // Atributo público para el nombre del producto
    public string Nombre;
    // Constructor que recibe código, nombre, precio y los asigna
    public Producto(string c, string n)
    {
        Codigo = c;
        Nombre = n;
    }
    // Sobrescribe Equals para considerar dos productos iguales si tienen el mismo código
    public override bool Equals(object? otroProducto)
    {
        if (otroProducto == null || otroProducto.GetType() != GetType())
            return false;

        Producto otroPro = (Producto)otroProducto;
        return this.Codigo == otroPro.Codigo;
    }
    // Sobrescribe GetHashCode para que coincida con Equals, usando el código como base
    public override int GetHashCode()
    {
        return (Codigo).GetHashCode();
    }
    // Función CompareTo para poder comprar un producto con otro por orden alfabético
    public int CompareTo(Producto? otroProducto)
    {
        if (otroProducto == null)
            return 1; 
        return Nombre.CompareTo(otroProducto.Nombre);
    }
    // Descripción del Producto
    public override string ToString()
    {
        return $"Código: {this.Codigo}, Nombre: {this.Nombre}";
    }
}