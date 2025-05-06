public class ConjuntoDeEnteros
{
    private int[] datos = new int[10];

    private int nDatos;

    int pos;

    private void CrecerSiEsNecesario(){
        if (nDatos == datos.Length){
            int[] aux = new int[datos.Length + 1];
            for (int i = 0; i < nDatos; i++){
                aux[i] = datos[i];
            }
            datos = aux;
        }
    }

    private int IndexOf(int n){
        for (int i = 0; i < nDatos; i++){
            if (datos[i] == n){
                pos = i;
            }
        }

        return pos;
    }

    public bool Contains(int n){
        bool encontrado = false;

        for(int i = 0; i < nDatos; i++){
            if (datos[i] == n){
                encontrado = true;
            }
        }

        return encontrado;
    }

    public bool Add(int n){
        bool agregado = false;

        if (!Contains(n)){
            CrecerSiEsNecesario();
            datos[nDatos] = n;
            nDatos++;
            agregado = true;
        }

        return agregado;

    }

    public int Lenght(){
        return datos.Length;

    }

    public bool Delete(int n){
        bool eliminado = false;
        pos = IndexOf(n);

        if (pos != -1){
            for (int i = pos; i < nDatos - 1; i++){
                datos[i] = datos[i + 1];
            }
            nDatos--;
            eliminado = true;
        }

        return eliminado;
    }

    public override string ToString(){
        string cadena = "{";
        for (int i = 0; i < nDatos; i++){
            cadena += datos[i];
            if (i < nDatos - 1){
                cadena += ", ";
            }
        }
        cadena += "}";
        return cadena;
    }
}