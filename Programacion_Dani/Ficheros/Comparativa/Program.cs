using Comparativa;
public class Program {
    public static void Main(string[] args) {
        Comparativa.Producto producto1 = new Comparativa.Producto("P001", "Televisor 4K");
        Comparativa.Producto producto2 = new Comparativa.Producto("P002", "Smartphone 5G");

        Console.WriteLine($"Producto 1: {producto1.Codigo}, {producto1.Nombre}");
        Console.WriteLine($"Producto 2: {producto2.Codigo}, {producto2.Nombre}");
        // Comparativa comp = new Comparativa("datos.csv");
        // comp.AñadirArticulo("MediaMarkt", "P002", "Smartphone", 599.99);
        // comp.ModificarPrecio("P001", "Amazon", 1150.00);
        // Console.WriteLine(comp.ListarPreciosDeProducto("P001"));
        // comp.GuardarCSV("datos_actualizados.csv");
    }

}

