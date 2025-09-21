using Library.Interfaces;

namespace Library;

public class Mago: IMagia
{
    private Personaje personaje;

    public Mago(Personaje p)
    {
        this.personaje = p;
    }


    public int HechizoMagico()
    {
       // return personaje.items.OfType<LibroDeHechizos>().Sum(libro => libro.podertotal);
       throw new NotImplementedException();
    }
}