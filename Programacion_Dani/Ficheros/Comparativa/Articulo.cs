using Comparativa;
public class Articulo {
    public string Vendedor;
    Comparativa.Producto Producto;

    decimal Precio;

    public Articulo(string vendedor, Comparativa.Producto producto, decimal precio) {
        Vendedor = vendedor;
        Producto = producto;
        Precio = precio;
    }
}