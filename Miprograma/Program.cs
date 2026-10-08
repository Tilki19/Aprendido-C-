//Console.WriteLine("Hello, World!");
using System.Collections;

Usuario objetoUsuario = new Usuario();
objetoUsuario.Nombre = "Yared Medina ";
objetoUsuario.Ingresar();

Console.WriteLine(" ");
// Ejemplo Mascota!!
var m = new Mascota("Misu");
m.Saludar();

Console.WriteLine(" ");
// Prctica giada
var gato = new Mimascota("Ramona", 3);
gato.Presentarse();

Console.WriteLine(" ");
// Reto Ana
Console.WriteLine(new Saludo().Decir("Ana"));

Console.WriteLine(" ");
// Practica 1
var l1 = new Libro("Cien años de soledad", "García Márquez");
var l2 = new Libro("El coronel no tiene quien le escriba");
l1.Prestar();
Console.WriteLine(l1.Descripcion());
Console.WriteLine(l2.Descripcion());

Console.WriteLine(" ");
// TRES COSNTRUTROES
Bob bobvacio = new Bob();
Console.WriteLine("----------------");
Bob bobmensaje = new Bob("Soy Bob el Constructor y tengo un Mensaje");
Console.WriteLine("----------------");
ArrayList milistica = new ArrayList();
milistica.Add("Martillo");
milistica.Add("Destornillador");
milistica.Add("Taladro");
milistica.Add("Metro");

Bob bobMilistica = new Bob(milistica);