using System.IO;
using Microsoft.Win32.SafeHandles;
public class Program
{
    public static void Main(string[] args)
    {
        string? NOMBRE_FICH = "numeros.txt";
        FileStream fs = new FileStream(NOMBRE_FICH, FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        int num;
        NumeroSimpatico ns;
        string? linea;

        while ((linea = sr.ReadLine()) != null)
        {
            try
            {
                num = Convert.ToInt32(linea);
                ns = new NumeroSimpatico();
                linea = linea.Trim();
                foreach (char dig in linea)
                {
                    ns.addDigito(dig - '0');
                }
                if (ns.isValido())
                {
                    Console.WriteLine(num);
                }
            }
            catch (FormatException) { 

            }
        }
        sr.Close();
    }
}