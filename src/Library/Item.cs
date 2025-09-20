namespace Library;

public class Item
{
    public string Name { get; }

    public int Attack { get; set; }
        
    public int Defense { get; set; }

    public Item(int attack, int defense)
    {
        this.Attack = attack;
        this.Defense = defense;
    }
}