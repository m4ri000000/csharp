using System;
class DNAsequence
{
    private string sequence;
    public DNAsequence(string sequence)
    {
        this.sequence = sequence;
    }
    public override bool Equals(object? obj)
    {
        if (obj is DNAsequence other)
        {
            //primero verifico si la longitud de las secuencias es la misma
            if (sequence.Length != other.sequence.Length) return false; 
            int len = sequence.Length; //por practicidad
            for(int i = 0; i < len; i++)
            {
                bool match = true;
                for (int j = 0; j < len; j++)
                {
                    if (sequence[(i + j) % len] != other.sequence[j]) //lógica para analizar si las secuencias son iguales
                    {
                        match = false; //si lo que aparece en la secuencia original en la posicion [(i + j) % len] es distinto a lo que encuentro en la posicion [j] de la otra secuencia, termino el bucle
                        break;
                    }
                }
                if (match) return true;
            }
        }
        return false;
    }
    public override int GetHashCode()
    {
        return sequence.GetHashCode();
    }
    public override string ToString()
    {
        return sequence;
    }
}
class Program
{
    static void Main()
    {
        DNAsequence seq1 = new DNAsequence("ATGCGTAT");
        DNAsequence seq2 = new DNAsequence("ATATGCGT");
        DNAsequence seq3 = new DNAsequence("GCTAGCTA");

        Console.WriteLine(seq1.Equals(seq2)); 
        Console.WriteLine(seq1.Equals(seq3)); 
    }
}