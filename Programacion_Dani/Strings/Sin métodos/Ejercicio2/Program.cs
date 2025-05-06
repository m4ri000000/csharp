// (2) Solicitada una frase y una letra, encontrar el número de veces que dicha letra aparece en la frase dada.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int suma = 0;
        Console.WriteLine("Introduce tu frase: ");
        string? frase = Console.ReadLine();
        Console.WriteLine("Dame una letra: ");
        char? letra = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        for(int i = 0; i < frase?.Length; i++){
            // Console.WriteLine($"[LOG] Letra {frase[i],1}, i {i,3}");
            Console.WriteLine(letra);
            if(frase[i] == letra){
                suma ++;
            }
        }
        Console.WriteLine($"Tienes un total de {suma} letras, que coinciden con la introducida.");
    }
}