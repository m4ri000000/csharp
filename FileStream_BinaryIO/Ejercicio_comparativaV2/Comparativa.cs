using System;
using System.Text;
using espacio_Articulo;
namespace espacio_comparativa;
public class Comparativa
{
    // Lista privada donde se almacenan todos los artículos
    private List<Articulo> articulos = new List<Articulo>();
    // Constructor que recibe una ruta de archivo CSV, lee el contenido y carga los artículos en la lista
    public Comparativa(string ruta)
    {
        string? linea;
        try
        {
            // Se abre el archivo para su lectura
            using (StreamReader? docCSV = new StreamReader(new FileStream(ruta, FileMode.Open)))
            {
                // Lee línea por línea
                while ((linea = docCSV.ReadLine()) != null)
                {
                    // Divide cada línea en campos separados por punto y coma
                    string[] campos = linea.Split(';');
                    // Crea un nuevo artículo con los datos leídos
                    Articulo nuevoArticulo = new Articulo(campos[0], campos[1], campos[2], campos[3]);
                    // Lo agrega a la lista
                    articulos.Add(nuevoArticulo);
                }
            }
        }
        // Captura errores si el archivo no se encuentra o no hay permisos
        catch (System.IO.FileNotFoundException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (UnauthorizedAccessException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (IndexOutOfRangeException e) { Console.WriteLine($"Error -> {e.Message}"); }
    }
    // Función para guardar el contenido de la lista en un archivo CSV
    public void GuardarCSV(string ruta)
    {
        // Verificación para que la ruta no este vacía
        if (ruta == null)
            throw new Exception("La ruta esta vacía");
        try
        {
            // Crea y abre el archivo de la ruta especificada para su escritura
            using (StreamWriter? docCSV = new StreamWriter(new FileStream(ruta, FileMode.Create)))
            {
                // Escribe cada artículo como línea en el archivo
                for (int i = 0; i < articulos.Count; i++)
                {
                    docCSV.WriteLine($"{articulos[i].Vendedor};{articulos[i].Producto.Codigo};{articulos[i].Producto.Nombre};{articulos[i].Precio}");
                }
            }
        }
        // Captura errores si el archivo no se encuentra o no hay permisos
        catch (System.IO.FileNotFoundException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (UnauthorizedAccessException e) { Console.WriteLine($"Error -> {e.Message}"); }
    }
    // Función para añadir un nuevo producto a la lista
    public void AñadirProducto(string vendedor, string codigo, string nombre, decimal precio)
    {
        // Verificación para que el campo vendedor, código y nombre no estén vacíos
        if (vendedor == null || codigo == null || nombre == null)
            throw new Exception("Alguno de los campos está vacío");
        // Verifica que no exista ya un producto con el mismo código
        int i = 0;
        while (i < articulos.Count && articulos[i].Producto.Codigo != codigo)
            i++;
        // Crea y agrega el nuevo artículo
        if (i == articulos.Count) {
            Articulo nuevoArticulo = new Articulo(vendedor, codigo, nombre, Convert.ToString(precio));
            articulos.Add(nuevoArticulo);
        }
    }
    // Función para modificar el precio de un producto ya existente
    public void ModificarPrecio(string codigo, string vendedor, decimal nuevoPrecio)
    {
        // Verificación para que ningún campo esté vacío
        if (codigo == null || vendedor == null)
            throw new Exception("Alguno de los campos está vacío");
        // Busca el artículo con ese vendedor y código
        int i = 0;
        while (i < articulos.Count && articulos[i].Vendedor != vendedor && articulos[i].Producto.Codigo != codigo)
            i++;
        // Si encontro el vendedor y código se le asignara a dicho articulo el nuevo precio
        if (i != articulos.Count)
            articulos[i].Precio = nuevoPrecio;
        else
            // Si no se ha realizado la modificación, lanza una excepción
            throw new Exception("Articulo no encontrado");
    }
    // Función que devuelve una lista de Articulos con el código especificado 
    public string ListarPreciosDeProducto(string codigo)
    {
        // Verificación para que el código no este vacío
        if (codigo == null)
            throw new Exception("El código no puede ser nulo");
        StringBuilder resultado = new StringBuilder();
        // Busca todos los artículos con ese código
        for (int i = 0; i < articulos.Count; i++)
        {
            if (articulos[i].Producto.Codigo == codigo)
            {
                // Escribir en el stringbuilder todas las lineas de los Articulos con dicho código
                resultado.AppendLine($"Vendedor: {articulos[i].Vendedor} - Precio: {articulos[i].Precio}");
            }
        }
        // Retorno del stringbuilder
        return resultado.ToString();
    }
    // Descripción de todos los Articulos de la lista de Comparativa
    public override string ToString()
    {
        StringBuilder s = new StringBuilder();
        foreach (Articulo art in articulos)
            // Escribir en el stringbuilder todas las lineas de los Articulos de la lista
            s.AppendLine(art.ToString());
        // Retorno del stringbuilder
        return s.ToString();
    }
}