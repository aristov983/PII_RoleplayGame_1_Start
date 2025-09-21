using Library.Interfaces;

namespace Library;

public class Elfo : IMagia, IAyudante
{
    private Personaje personaje;

    public Elfo(Personaje p)
    {
        this.personaje = p;
    }
    
    public void Curar(Personaje aliado)
    {
        aliado.Curar();
    }

    public int HechizoMagico()
    {
        // return personaje.items.OfType<LibroDeHechizos>().Sum(libro => libro.podertotal);
        throw new NotImplementedException();
    }
}