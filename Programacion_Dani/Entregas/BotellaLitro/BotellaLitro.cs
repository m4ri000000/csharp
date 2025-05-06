public class PruebaBotellaLitro
{
    public static void Main(string[] args)
    {
        // Crear dos instancias de `BotellaLitro`
        BotellaLitro Botella1 = new BotellaLitro();
        BotellaLitro Botella2 = new BotellaLitro();
        // Añadir 1.5 litros a una botella y mostrar la cantidad sobrante
        float resto1 = Botella1.Añadir(1.5f);
        Botella1.Abrir();
        float resto2 = Botella1.Añadir(1.5f);
        // Quitar 0.3 litros de la misma botella y mostrar la cantidad realmente extraída
        float extraido = Botella1.Quitar(0.3f);

        Console.WriteLine($"Contenido botella cerrada: {resto1}");
        Console.WriteLine($"Contenido botella abierta: {resto2}");
        Console.WriteLine($"Extraido: {extraido}");
    }
}

public class BotellaLitro
{
    private float _contenido;
    private const float Max_Contenido = 1;
    private bool _abierta;

    private float Contenido
    {
        get { return _contenido; }
        set
        {
            if (value >= 0 && value <= Max_Contenido)
                _contenido = value;
            else if (value < 0)
                _contenido = 0;
            else
                _contenido = Max_Contenido;
        }
    }

    private bool Abierta
    {
        get { return _abierta; }
        private set { _abierta = value; }
    }

    // Constructores
    public BotellaLitro()
    {
        Contenido = 0;
        Abierta = false;
    }

    public BotellaLitro(float contenidoInicial) : this()
    {
        Contenido = contenidoInicial;
    }

    public BotellaLitro(bool abiertaInicial) : this()
    {
        Abierta = abiertaInicial;
    }

    public BotellaLitro(float contenidoInicial = 0, bool abiertaInicial = false) : this()
    {
        Contenido = contenidoInicial;
        Abierta = abiertaInicial;
    }


    // Abrir y cerrar
    public void Abrir()
    {
        Abierta = true;
    }

    public void Cerrar()
    {
        Abierta = false;
    }

    // Estado llena o vacía
    public bool EstaLlena()
    {
        return Contenido == Max_Contenido;
    }

    public bool EstaVacia()
    {
        return Contenido == 0;
    }

    // Quitar y agregar líquido
    public float Quitar(float liq)
    {
        if (liq <= 0)
        {
            throw new ArgumentOutOfRangeException("La cantidad a quitar debe ser mayor que cero.");
        }

        if (!Abierta)
        {
            throw new InvalidOperationException("No se puede quitar líquido de una botella cerrada.");
        }

        float cantidadRetirada = 0;

        if (EstaVacia())
        {
            cantidadRetirada = 0;
        }
        else
        {
            if (Contenido >= liq)
            {
                Contenido -= liq;
                cantidadRetirada = liq;
            }
            else
            {
                cantidadRetirada = _contenido;
                Contenido = 0;
            }
        }

        return cantidadRetirada;
    }

    public float Añadir(float liq)
    {
        if (liq <= 0)
        {
            throw new ArgumentOutOfRangeException("La cantidad a añadir debe ser mayor que cero.");
        }

        float cantidadSobrante = 0;

        if (!Abierta)
        {
            throw new InvalidOperationException("No se puede añadir líquido a una botella cerrada.");
        }

        if (EstaLlena())
        {
            cantidadSobrante = liq;
        }
        else
        {
            if (Contenido + liq <= Max_Contenido)
            {
                Contenido += liq;
            }
            else
            {
                cantidadSobrante = (Contenido + liq) - Max_Contenido;
                Contenido = Max_Contenido;
            }
        }

        return cantidadSobrante;
    }

    public override string ToString()
    {
        return $"Contenido: {Contenido} litros | Estado: {(Abierta ? "Abierta" : "Cerrada")}";
    }
}
