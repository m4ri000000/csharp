using System;

public class Ejercicio
{
    public static bool comprobarPassword(string pass){

        if (pass.Length >= 4 && pass.Length <= 6){
            for (int i = 0; i < pass.Length; i++){
                char c = Convert.ToChar(pass[i]);
                if (Char.IsDigit(c)) return true;
            }
        }

        return false;
    }
}