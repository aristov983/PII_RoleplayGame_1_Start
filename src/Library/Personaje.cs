namespace Library;

public class Personaje
{
    public List<Item> items = new List<Item>();

    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int VidaMaxima { get; set; }
    
    public Personaje(string nombre, int vida) //constructor
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.VidaMaxima = vida;
    }

    public int AtaqueTotal()
    {
        int suma = 0;
        foreach (Item item in items)
        { 
            suma += item.Attack;
        }

        return suma;
    }

    public int DefensaTotal()
    {
        int suma = 0;
        foreach (Item item in items)
        {
            suma += item.Defense;
        }
        return suma;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
    
    public void Ataque(Personaje enemigo)
    {
        int danio = AtaqueTotal() - enemigo.DefensaTotal();
        if (danio > 0)
            enemigo.Vida -= danio;
        if (enemigo.Vida < 0)
            enemigo.Vida = 0;
    }
    
    public void Curar()
    {
        Vida = VidaMaxima; // por las dudas lo cura a salud maxima.
    }


    
}