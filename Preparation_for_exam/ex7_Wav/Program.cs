using System;
using System.IO;

public class Ejemplo_Wav
{
    public static void Main()
    {
        Console.WriteLine("Información de archivos WAV");
        Console.WriteLine("Dime el nombre del fichero: ");
        string nombre = Console.ReadLine(); // El usuario ingresa el nombre del archivo

        if (!File.Exists(nombre))
        {
            Console.WriteLine("¡No se encontró el archivo!");
        }
        else
        {
            try
            {
                using (BinaryReader fichero = new BinaryReader(File.Open(nombre, FileMode.Open)))
                {
                    // Leer el encabezado del archivo WAV (primeros 4 bytes deben ser 'RIFF')
                    char marca1 = Convert.ToChar(fichero.ReadByte());
                    char marca2 = Convert.ToChar(fichero.ReadByte());
                    char marca3 = Convert.ToChar(fichero.ReadByte());
                    char marca4 = Convert.ToChar(fichero.ReadByte());

                    if (marca1 != 'R' || marca2 != 'I' || marca3 != 'F' || marca4 != 'F')
                    {
                        Console.WriteLine("No parece un archivo WAV.");
                    }
                    else
                    {
                        Console.WriteLine($"Marca del archivo: {marca1}{marca2}{marca3}{marca4}");

                        // Leer la longitud del archivo WAV
                        int longitud = fichero.ReadInt32();
                        Console.WriteLine($"Longitud del archivo: {longitud} bytes");

                        // Buscar el encabezado "fmt " que sigue a la marca RIFF
                        fichero.BaseStream.Seek(20, SeekOrigin.Begin);
                        string fmtHeader = new string(fichero.ReadChars(4));
                        if (fmtHeader != "fmt ")
                        {
                            Console.WriteLine("Encabezado 'fmt ' no encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Encabezado 'fmt ' encontrado.");

                            // Leer el formato del archivo WAV
                            int formato = fichero.ReadInt16();
                            Console.WriteLine($"Formato: {formato}");

                            // Leer el número de canales
                            int canales = fichero.ReadInt16();
                            Console.WriteLine($"Canales: {canales}");

                            // Leer la tasa de muestreo
                            int tasaMuestreo = fichero.ReadInt32();
                            Console.WriteLine($"Tasa de muestreo: {tasaMuestreo} Hz");

                            // Leer el tamaño de los datos por segundo
                            int bytesPorSeg = fichero.ReadInt32();
                            Console.WriteLine($"Bytes por segundo: {bytesPorSeg}");

                            // Leer el tamaño de los datos por muestra
                            int bytesPorMuestra = fichero.ReadInt16();
                            Console.WriteLine($"Bytes por muestra: {bytesPorMuestra}");

                            // Leer la cantidad de bits por muestra
                            int bitsPorMuestra = fichero.ReadInt16();
                            Console.WriteLine($"Bits por muestra: {bitsPorMuestra}");

                            // Saltar al encabezado "data" donde comienza la información de los datos
                            fichero.BaseStream.Seek(36, SeekOrigin.Begin);
                            string dataHeader = new string(fichero.ReadChars(4));
                            if (dataHeader != "data")
                            {
                                Console.WriteLine("Encabezado 'data' no encontrado.");
                            }
                            else
                            {
                                Console.WriteLine("Encabezado 'data' encontrado.");

                                // Leer la longitud de los datos
                                int longitudDatos = fichero.ReadInt32();
                                Console.WriteLine($"Longitud de los datos: {longitudDatos} bytes");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar el archivo: {ex.Message}");
            }
        }
    }
}