using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("¿Cuántos jugadores son?");
        int numeroParticipantes = Convert.ToInt32(Console.ReadLine());

        int[] resultado = Modulos.generaAsignaciones(numeroParticipantes);

        for(int i = 0; i < numeroParticipantes; i++){
            Console.WriteLine($"A {i} le toca {resultado[i]}");
        }
    }
}