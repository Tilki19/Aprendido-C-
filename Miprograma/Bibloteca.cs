class Libro
{
    private string titulo, autor;
    private bool prestado;

    public Libro (string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
    }
    public Libro (string titulo) : this(titulo,"Anonimo"){}

    public void Prestar() => prestado = true;

    public string Descripcion()
    {
        var estado = prestado ? "Prestado" : "Disponible";
        return $"{titulo} | {autor} [{prestado}]";  
    }  
}