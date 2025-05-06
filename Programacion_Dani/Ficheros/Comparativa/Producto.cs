namespace Comparativa;
public class Producto : IComparable<Producto> {
    private string Codigo;
    private string Nombre;

    public Producto(string codigo, string nombre) {
        Codigo = codigo;
        Nombre = nombre;
    }

    public override bool Equals(object obj) {
        if (obj is Producto otroProducto) {
            return Codigo == otroProducto.Codigo && Nombre == otroProducto.Nombre;
        }
        return false;
    }

    public override int GetHashCode() {
        return Codigo.GetHashCode() ^ Nombre.GetHashCode();
    }

    public int CompareTo(Producto? other) {
        if (other == null) return 1;
        return this.Nombre.CompareTo(other.Nombre);
    }

    public override string ToString() {
        return $"Código: {Codigo}, Nombre: {Nombre}";
    }
}