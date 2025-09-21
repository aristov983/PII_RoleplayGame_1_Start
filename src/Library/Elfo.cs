using Library.Interfaces;

namespace Library;

public class Elfo : IAyudante
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
}