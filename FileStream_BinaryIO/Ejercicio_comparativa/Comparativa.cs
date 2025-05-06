using System;
using System.Text;
using espacio_Articulo;
namespace espacio_comparativa;
public class Comparativa
{
    private string rutaCSVDeArticulos;
    private string? rutaCSVDatosModificados;
    private List<Articulo> articulos = new List<Articulo>();
    public Comparativa(string ruta)
    {
        string? linea;
        try
        {
            using (StreamReader? docCSV = new StreamReader(new FileStream(ruta, FileMode.Open)))
            {
                while ((linea = docCSV.ReadLine()) != null)
                {
                    string[] campos = linea.Split(';');
                    Articulo nuevoArticulo = new Articulo(campos[0], campos[1], campos[2], campos[3]);
                    articulos.Add(nuevoArticulo);
                }
            }
        }
        catch (System.IO.FileNotFoundException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (UnauthorizedAccessException e) { Console.WriteLine($"Error -> {e.Message}"); }
        rutaCSVDeArticulos = ruta;
    }
    public void GuardarCSV(string ruta)
    {
        if (ruta == null)
            throw new Exception("La ruta esta vacia");
        else if (!File.Exists(ruta))
            File.Create(ruta).Close();
        rutaCSVDatosModificados = ruta;
    }
    public void AñadirProducto(string vendedor, string codigo, string nombre, decimal? precio)
    {
        if (vendedor == null || codigo == null || nombre == null || precio == null)
            throw new Exception("Alguno de los campos esta vacio");
        try
        {
            string[] lineas = File.ReadAllLines(rutaCSVDeArticulos);
            string[] campos;
            for (int i = 0; i < lineas.Length; i++)
            {
                campos = lineas[i].Split(';');
                if (campos[1] == codigo)
                    throw new Exception("El codigo ya existe");
            }
            using (StreamWriter? docCSV = new StreamWriter(new FileStream(rutaCSVDeArticulos, FileMode.Append)))
            {
                docCSV.WriteLine($"{vendedor};{codigo};{nombre};{precio}");
                Articulo nuevoArticulo = new Articulo(vendedor, codigo, nombre, Convert.ToString(precio));
                articulos.Add(nuevoArticulo);
            }
        }
        catch (System.IO.FileNotFoundException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (UnauthorizedAccessException e) { Console.WriteLine($"Error -> {e.Message}"); }
    }
    public void ModificarPrecio(string codigo, string vendedor, decimal? nuevoPrecio)
    {
        if (codigo == null || vendedor == null || nuevoPrecio == null)
            throw new Exception("Alguno de los campos esta vacio");
        try
        {
            bool modificacionRealizada = false;
            string[] lineas = File.ReadAllLines(rutaCSVDeArticulos);
            string[] campos;
            for (int i = 0; i < lineas.Length && !modificacionRealizada; i++)
            {
                campos = lineas[i].Split(';');
                if (campos[0] == vendedor && campos[1] == codigo)
                {
                    if (rutaCSVDatosModificados != null)
                    {
                        using (StreamWriter? docCSVDatosModf = new StreamWriter(new FileStream(rutaCSVDatosModificados, FileMode.Append)))
                        {
                            docCSVDatosModf.WriteLine($"Modificación (Linea: {i + 1}, Precio Anterior: {campos[3]}, Precio Nuevo: {nuevoPrecio})");
                        }
                    }
                    campos[3] = Convert.ToString(nuevoPrecio);
                    lineas[i] = string.Join(";", campos);
                    modificacionRealizada = true;
                    articulos[i] = new Articulo(campos[0], campos[1], campos[2], Convert.ToString(nuevoPrecio));
                }
            }
            if (modificacionRealizada)
                File.WriteAllLines(rutaCSVDeArticulos, lineas);
            else
                throw new Exception("No se encontro el codigo y vendedor especificados");
        }
        catch (System.IO.FileNotFoundException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (UnauthorizedAccessException e) { Console.WriteLine($"Error -> {e.Message}"); }
    }
    public string ListarPreciosDeProducto(string codigo)
    {
        if (codigo == null)
            throw new Exception("El código no puede ser nulo");

        try
        {
            StringBuilder resultado = new StringBuilder();
            string[] lineas = File.ReadAllLines(rutaCSVDeArticulos);
            bool encontrado = false;

            foreach (var linea in lineas)
            {
                string[] campos = linea.Split(';');
                if (campos.Length >= 4 && campos[1] == codigo)
                {
                    resultado.AppendLine($"Vendedor: {campos[0]} - Código: {campos[1]} - Nombre: {campos[2]} - Precio: {campos[3]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                throw new Exception("No se encontraron articulos con el código especificado");

            return resultado.ToString();
        }
        catch (System.IO.FileNotFoundException e)
        {
            return $"Error -> {e.Message}";
        }
        catch (UnauthorizedAccessException e)
        {
            return $"Error -> {e.Message}";
        }
    }
    public override string ToString()
    {
        foreach (Articulo m in articulos)
            Console.WriteLine(m);
        return "Estos son todos los articulos.";
    }
}