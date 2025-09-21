using System;
using Library;

class Program
{
    static void Main(string[] args)
    {
        //Creo los personajes.
        Personaje Pmago = new Personaje("Mago rdito", 100);
        Mago mago = new Mago(Pmago);
        
        Personaje PElfo = new Personaje("Esclavo de papanoel", 100);
        Elfo elfo = new Elfo(PElfo);
        
        Personaje Penano = new Personaje("Mido 1.70", 100);
        Enano enano = new Enano(Penano);
        
        //Creo un libro de hechizos y se lo asigno al mago.
        var libro = new LibroDeHechizos();
        libro.AgregarHechizo(new Hechizo("Bondiola", 20, 5));
        libro.AgregarHechizo(new Hechizo("Asado", 20, 5));
        libro.AgregarHechizo(new Hechizo("Milanesa", 20, 5));

        mago.Libro = libro;
        
        // Creo el mostrador
        MostradorDeAtaques mostrador = new MostradorDeAtaques();

        //El mago ataca al elfo
        mago.Ataque(PElfo);
        mostrador.MostrarAtaque(Pmago, PElfo, mago.Libro.Hechizos); 

        //Ahora el enano ataca al mago
        Item hacha = new Item("Hacha de guerra", 15, 5); // se crea un item. 
        Penano.AddItem(hacha); // El enano agarra su arma.
        Penano.Ataque(Pmago); // lo ataca al mago.
        mostrador.MostrarAtaque(Penano, Pmago, hacha);  
    }
}
