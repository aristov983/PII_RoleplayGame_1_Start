using Library.Interfaces;

namespace Library;

public class Enano : IEnano
{
    private Personaje personaje;

    public Enano(Personaje p)
    {
        this.personaje = p;
    }
    
    // Ataque físico basado en los elementos del personaje (armas)
    public void AtaqueTemperamental(Personaje objetivo)
    {
        int dano = personaje.AtaqueTotal() - objetivo.DefensaTotal();
        if (dano > 0)
            objetivo.Vida -= dano;

        if (objetivo.Vida < 0)
            objetivo.Vida = 0;
    }

    // Defensa basada en los elementos del personaje (armaduras)
    public int DefensaNatural()
    {
        return personaje.DefensaTotal();
    }
}