
public class Acumulador
{
    private int val;

    public void Add(int n){
        val += n;
    }

    public void Rem(int n){
        val -= n;

        if (val < 0) val = 0;
    }
    public int Val() { return val; }
}