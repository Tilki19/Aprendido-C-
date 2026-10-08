class Mascota(string nombre)
{
    public void Saludar() =>
        Console.WriteLine($"Miau, Soy {nombre}");
}

// Practica Giada 01

class Mimascota(string nombre, int edad)
{
    public void Presentarse() => 
        Console.WriteLine($"Soy {nombre} y tengo {edad} años");
}