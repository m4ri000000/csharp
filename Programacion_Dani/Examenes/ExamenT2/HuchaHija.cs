/* 2.- Implementa una función Sorteo(…) en una nueva clase HuchaHija (que herede de Hucha) que
reciba un array de objetos Hucha y que retorne una de ellas elegida al azar de entre aquellas que no
estén vacías.
 … …
Hucha resultado = HuchaHija.sorteo(Hucha[] huchas);
 … … …
consideraciones.- - El atributo saldo de la clase Hucha es privado. Esto no se debe cambiar.
- Hucha hija solo dispone de un constructor, que inicializa su saldo a cero euros*/

public class HuchaHija : Hucha
{
    public HuchaHija() : base(0M)
    {
    }

    public Hucha sorteo(Hucha[] huchas)
    {
        Random random = new Random();
        int Ganador = random.Next(huchas.Length);
        return huchas[Ganador];
    }
}