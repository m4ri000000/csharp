public class Modulos
{
    public static int[] generaAsignaciones(int participantes)
    {
        int[] parejas = new int[participantes];

        int temp, i, pos;

        Random r = new Random();

        for (int j = 0; j < parejas.Length; j++)
        {
            parejas[j] = j;
        }


        for (i = 0; i < participantes - 3; i++)
        {
            pos = r.Next(i + 1, participantes);

            temp = parejas[i];
            parejas[i] = parejas[pos];
            parejas[pos] = temp;
        }

        temp = parejas[i];
        parejas[i] = parejas[i + 1];
        parejas[i + 1] = temp;


        return parejas;
    }
}