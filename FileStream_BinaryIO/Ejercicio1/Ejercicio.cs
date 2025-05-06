using System;
public class Ejercicio
{
    public static void Main()
    {
        string? path = "numeros.txt";

        // Ejercicio 1
        Console.WriteLine("Ejercicio 1");
        StreamReader doc = new StreamReader(new FileStream(path, FileMode.Open));
        string? n;
        while ((n = doc.ReadLine()) != null)
        {
            Console.WriteLine(n);
        }
        doc.Close();

        // Ejercicio 2
        Console.WriteLine("\nEjercicio 2");
        StreamReader docu = new StreamReader(new FileStream(path, FileMode.Open));
        int nu = 0;
        string? comprobar;
        while ((comprobar = docu.ReadLine()) != null)
        {
            try
            {
                nu += Convert.ToInt32(comprobar);
            }
            catch (FormatException) { }
        }
        docu.Close();
        Console.WriteLine(nu);

        // Ejercicio 3
        /*Console.WriteLine("\nEjercicio 3");
        int linea = 0;
        int nu3 = 0;
        string? comprobar3;

        StreamReader? docu3 = null;
        StreamWriter? Fails = null;
        try
        {
            docu3 = new StreamReader(new FileStream("numeros.txt", FileMode.Open));
            Fails = new StreamWriter(new FileStream("numeros.err", FileMode.Create));

            while ((comprobar3 = docu3.ReadLine()) != null)
            {
                linea++;
                try
                {
                    nu3 += Convert.ToInt32(comprobar3);
                }
                catch (FormatException)
                {
                    Fails.WriteLine($"Linea: {linea} // \"{comprobar3}\"");
                }
            }
        }
        catch (System.IO.FileNotFoundException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (UnauthorizedAccessException e) { Console.WriteLine($"Error -> {e.Message}"); }
        finally
        {
            if (Fails != null)
                Fails.Close();
            if (docu != null)
                docu.Close();
        }
        Console.WriteLine(nu);*/

        // Ejercicio 4
        Console.WriteLine("\nEjercicio 3");
        int linea = 0;
        int nu3 = 0;
        string? comprobar3;
        try
        {
            using (StreamReader? docu3 = new StreamReader(new FileStream("numeros.txt", FileMode.Open)))
            using (StreamWriter? Fails = new StreamWriter(new FileStream("numeros.err", FileMode.Create)))
            {
                while ((comprobar3 = docu3.ReadLine()) != null)
                {
                    linea++;
                    try
                    {
                        nu3 += Convert.ToInt32(comprobar3);
                    }
                    catch (FormatException)
                    {
                        Fails.WriteLine($"Linea: {linea} // \"{comprobar3}\"");
                    }
                }
            }
            Console.WriteLine(nu);
        }   
        catch (System.IO.FileNotFoundException e) { Console.WriteLine($"Error -> {e.Message}"); }
        catch (UnauthorizedAccessException e) { Console.WriteLine($"Error -> {e.Message}"); }
    }
}