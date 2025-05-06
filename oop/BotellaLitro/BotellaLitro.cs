using System;
class BotellaLitro
{
    private float contenido;
    private bool abierta;
    public BotellaLitro()
    {
        contenido = 0.0f;
        abierta = false;
    }
    public void Abrir()
    {
        abierta = true;
    }
    public void Cerrar()
    {
        abierta = false;
    }
    public bool EstaLlena()
    {
        return contenido >= 1.0f;
    }
    public bool EstaVacia()
    {
        return contenido <= 0.0f;
    }
    public float Anadir(float liq)
    {
        if (!abierta) //compruebo si la botella está abierta
        {
            Console.WriteLine("La botella está cerrada.");
            return liq; //devuelvo toda la cantidad que intentamos añadir
        }
        
        if (liq <= 0) //en caso de que se intente añadir una cantidad inferior a 0
        {
            Console.WriteLine("No se puede añadir una cantidad inferior a 0.");
            return 0.0f;
        }

        float capacidad = 1.0f - contenido; //creo una variable float que indica la capacidad restante en la botella
        if (liq > capacidad) //si añado más liquido que la capacidad restante de la botella 
        {
            float sobrante = liq - capacidad; //resto la capacidad del liquido añadido para ver cuanto sobra
            contenido = 1.0f;
            Console.WriteLine($"La botella ha sido llenada y sobran: {sobrante:F2} litros.");
            return sobrante; //regreso lo que sobró
        }
        else
        {
            contenido += liq;
            Console.WriteLine($"Se han añadido {liq:F2} litros. Contenido actual: {contenido:F2} litros.");
            return 0.0f;
        }
    }
    public float Quitar(float liq)
    {
        if (!abierta) //compruebo si la botella está abierta
        {
            Console.WriteLine("La botella está cerrada.");
            return 0.0f; //no se extrae nada
        }

        if (liq <= 0) //en caso de que se intente quitar una cantidad inferior a 0
        {
            Console.WriteLine("No se puede quitar una cantidad no válida de líquido.");
            return 0.0f;
        }

        if (liq > contenido)
        {
            float extraido = contenido; //creo una variable para ver cuanto he extraido de la botella
            contenido = 0.0f; //vacio la botella
            Console.WriteLine($"La botella se ha vaciado. Se extrajeron {extraido:F2} litros.");
            return extraido;
        }
        else
        {
            contenido -= liq;
            Console.WriteLine($"Se han extraído {liq:F2} litros. Contenido restante: {contenido:F2} litros.");
            return liq; //devuelvo la cantidad extraída
        }
    }
}
public class PruebaBotellaLitro
{
    public static void Main(string[] args)
    {
        //creo dos instancias de BotellaLitro
        BotellaLitro botella1 = new BotellaLitro();
        BotellaLitro botella2 = new BotellaLitro();
        botella1.Abrir(); 
        float sobrante = botella1.Anadir(1.5f); //añado 1.5 litros
        Console.WriteLine($"Cantidad sobrante: {sobrante:F2} litros.");
        float extraido = botella1.Quitar(0.3f); //quito 0.3 litros y muestro la cantidad realmente extraída
        Console.WriteLine($"Cantidad realmente extraída: {extraido:F2} litros.");
    }
}