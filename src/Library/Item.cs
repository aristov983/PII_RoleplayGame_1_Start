namespace Library;

public class Item
{
    public string Nombre { get; }

    public int Ataque { get; set; }
        
    public int Defensa { get; set; }

    public Item(string name ,int attack, int defense)
    {
        this.Nombre = name;
        this.Ataque = attack;
        this.Defensa = defense;
    }
}