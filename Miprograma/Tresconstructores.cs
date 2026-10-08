using System.Collections;
class Bob
{
    public Bob()
    {
        Console.WriteLine("Soy Bob el Constructor y estoy vacío");
    }
    public Bob(string Mensaje)
    {
        Console.WriteLine(Mensaje);
    }
    public Bob(ArrayList Lista){
        foreach (var elemento in Lista)
        {
            Console.WriteLine(elemento);
        }
    }
}