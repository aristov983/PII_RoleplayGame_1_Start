using System;
using Library;

class Program
{
    static void Main(string[] args)
    {
        //Creo los personajes

        Personaje Pmago = new Personaje("Mago rdito", 100);
        Mago mago = new Mago(Pmago);
        
        Personaje PElfo = new Personaje("Esclavo de papanoel", 100);
        Elfo elfo = new Elfo(PElfo);
        
        Personaje Penano = new Personaje("Mido 1.70", 100);
        Enano enano = new Enano(Penano);
        
        //Creo un libro de hechizos y se lo asigno al mago
        var libro = new LibroDeHechizos();
        libro.AgregarHechizo(new Hechizo("Bondiola", 20, 5));
        libro.AgregarHechizo(new Hechizo("Asado", 20, 5));
        libro.AgregarHechizo(new Hechizo("Milanesa", 20, 5));

        mago.Libro = libro;
        
        //El mago se enoja con el elfo y el enano pero decide solo atacar al elfo
        mago.Ataque(PElfo);
        Console.WriteLine($"El {PElfo.Nombre} tiene {PElfo.Vida} de vida");
        
    }
}