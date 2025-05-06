namespace DanielDarias;

public class Calificacion{
    public string Asignatura { get; }
    public float Nota { get; }

    public Calificacion(string _asignatura, float _nota){
        if(_nota < 0 || _nota > 10){
            throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 10");
        }
        Asignatura = _asignatura;
        Nota = _nota;
    }

    public override string ToString(){
        return $"{Asignatura} {Nota}";
    }
}