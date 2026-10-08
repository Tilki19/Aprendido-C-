class Usuario
{
    public string Nombre { get; set; }

    public void Ingresar()
    {
        Console.WriteLine(this.Nombre + "Ingresando");
    }
}


