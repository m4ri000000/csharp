using System;

public class ListaDeAsignaciones
{
    private int[] asignaciones;
    private int nAsignaciones;

    public ListaDeAsignaciones(int participantes)
    {
        asignaciones = new int[participantes];
        nAsignaciones = participantes;
        
        // Inicializa la lista con los índices
        for (int i = 0; i < participantes; i++)
        {
            asignaciones[i] = i;
        }
    }

    public void GeneraAsignaciones()
    {
        int temp, pos;
        Random r = new Random();

        for (int i = 0; i < nAsignaciones - 3; i++)
        {
            pos = r.Next(i + 1, nAsignaciones);

            // Intercambio
            temp = asignaciones[i];
            asignaciones[i] = asignaciones[pos];
            asignaciones[pos] = temp;
        }

        // Intercambio final de la última pareja
        temp = asignaciones[nAsignaciones - 3];
        asignaciones[nAsignaciones - 3] = asignaciones[nAsignaciones - 2];
        asignaciones[nAsignaciones - 2] = temp;
    }

    public int Length()
    {
        return nAsignaciones;
    }

    public int Get(int pos)
    {
        if (pos >= nAsignaciones)
            throw new Exception("Índice fuera de rango");
        return asignaciones[pos];
    }

    public int Set(int pos, int valor)
    {
        if (pos >= nAsignaciones)
            throw new Exception("Índice fuera de rango");
        asignaciones[pos] = valor;
        return asignaciones[pos];
    }

    public int Delete(int pos)
    {
        if (pos >= nAsignaciones)
            throw new Exception("Índice fuera de rango");

        int aux = asignaciones[pos];
        for (int i = pos; i < nAsignaciones - 1; i++)
        {
            asignaciones[i] = asignaciones[i + 1];
        }
        nAsignaciones--;
        return aux;
    }

    public override string ToString()
    {
        string aux = "";
        for (int i = 0; i < nAsignaciones - 1; i++)
        {
            aux += $"{asignaciones[i]}, ";
        }
        aux += $"{asignaciones[nAsignaciones - 1]}";

        return $"ListaDeAsignaciones {{ {aux} }}";
    }
}