namespace Library;

public class Character
{
    public List<Item> items = new List<Item>();

    public string Nombre { get; }
    public int MaxHealth { get; set; }

    public int TotalAttack()
    {
        int suma = 0;
        foreach (Item item in items)
        { 
            suma += item.Attack;
        }

        return suma;
    }

    public int TotalDefense()
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

    public Character(string nombre, int vida) //constructor
    {
        this.Nombre = nombre;
        this.MaxHealth = vida;
    }
    
}