using System.Net;
using Library.Interfaces;

namespace Library;

public class Mago: IMagia//el mago es el unico que puede usar el libro
{
    private Personaje personaje;
    public LibroDeHechizos Libro { get; set; }
    
    public Mago(Personaje p)
    {
        this.personaje = p;
    }


    public void LibroDePersonaje()
    {
        
    }

    public int HechizoMagico()
    {
        if (Libro == null) return 0; //si no tiene libro, no hace daño
        return Libro.Hechizos.Sum(h => h.Ataque);
    }

    public void Ataque(Personaje objetivo)//se calcula el daño de los hechizos del mago teniendo en cuenta la defensa
    {
            int danio = HechizoMagico() - objetivo.DefensaTotal();
            if (danio > 0)
                objetivo.Vida -= danio;
            if (objetivo.Vida < 0)
                objetivo.Vida = 0;
    }
}