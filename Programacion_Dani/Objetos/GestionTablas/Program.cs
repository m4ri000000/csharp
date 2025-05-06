public class Programa
{
    public static void Main(String[] arg)
    {
        ListaDeEnteros l = new ListaDeEnteros();
        l.Add(5);
        l.Add(-30);
        l.Add(51);
        l.Add(-3);
        l.Add(15);
        l.Add(23);
        l.Add(99);
        l.Add(0);
        l.Add(0);
        l.Add(-9);
        l.Add(1);
        l.Add(31);
        l.Delete(3);

        l.Set(4, 100);

        Console.WriteLine(l.ToString());
        for (int i = 0; i < l.Length(); i++)
        {
            System.Console.WriteLine($"datos[{i}]={l.Get(i)}");
        }
    }
}