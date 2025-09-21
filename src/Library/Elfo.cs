using Library.Interfaces;

namespace Library;

public class Elfo : IAyudante//el elfo es el unico que puede curar
{
    private Personaje personaje;

    public Elfo(Personaje p)
    {
        this.personaje = p;
    }
    
    public void Curar(Personaje aliado) //El elfo puede curar a los aliados
    {
        aliado.Curar();
    }
}