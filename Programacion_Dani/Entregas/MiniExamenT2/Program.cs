/*Realiza la tarea que se encomienda.  Sin usar documentación. 

* Implementa una función:  public static bool comprobarPassword(String pass)
   …  que devolverá true si la contraseña pasada como parámetro cumple las condiciones:

 Tiene entre 4 y 6 caracteres.
 Contiene un dígito



De la clase Char:
public static bool IsDigit (char c);*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(comprobarPassword("Examp1"));
    }

    public static bool comprobarPassword(string pass)
    {

        bool validacion = false;
        int i = 0;

        if (pass.Length >= 4 && pass.Length <= 6){
            while (i < pass.Length - 1 && !validacion) i++;
            
            if (Char.IsDigit(pass[i])) validacion = true;
        }

        return validacion;
    }
}