using System;

public class Nave
{
    private int tamaño = 1;
    private const int TamañoMax = 10;
    private int _vida = 100;
    private int limiteVida = 100;
    private const int LimiteVidaMax = 1000;
    private int disparo = 1;
    private const int DisparoMax = 10;
    private int escudo = 0;
    private const int EscudoMax = 10;

    public int Vida
    {
        get { return _vida; }
        set
        {
            if (value <= limiteVida)
            {
                _vida = value;
            }
            else
            {
                _vida = limiteVida;
            }
        }
    }

    public void MejorarEscudo()
    {
        if (escudo < EscudoMax)
        {
            escudo++;
        }
    }

    public void MejorarNave()
    {
        if (tamaño < TamañoMax)
        {
            tamaño++;
            if (limiteVida < LimiteVidaMax) 
                limiteVida += 100;
        }
    }

    public void MejorarDisparo()
    {
        if (disparo < DisparoMax)
        {
            disparo++;
        }
    }

    public void AumentarVida(int cantidad)
    {
        if (cantidad == 10 || cantidad == 100)
        {
            _vida += cantidad;
            if (_vida > limiteVida)
            {
                _vida = limiteVida;
            }
        }
        else
        {
            throw new ArgumentException("La cantidad de _vida a aumentar debe ser 10 o 100.");
        }
    }

    public void Atacar(int daño)
    {
        if (daño != 10 && daño != 100 && daño != 1000)
        {
            throw new ArgumentException("El daño debe ser 10, 100 o 1000.");
        }

        // Reducir el escudo por cada 10 unidades de ataque
        int reduccionEscudo = Math.Min(escudo, daño / 10);
        escudo -= reduccionEscudo;
        
        // Restar el daño restante a la _vida
        int dañoRestante = daño - (reduccionEscudo * 10);
        _vida -= dañoRestante;

        // Asegurar que la _vida no sea negativa
        if (_vida < 0)
        {
            _vida = 0;
        }
    }

    public override string ToString()
    {
        return $"Tamaño: {tamaño}\n" +
               $"Vida: {_vida}\n" +
               $"Límite de _vida: {limiteVida}\n" +
               $"Disparo: {disparo}\n" +
               $"Escudo: {escudo}";
    }
}
