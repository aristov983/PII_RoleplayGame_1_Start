namespace Library;

public class Hechizo
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public Hechizo (string nombre, int ataque, int defensa)
    {
        this.Nombre = nombre;
        this.Ataque = ataque;
        this.Defensa = defensa;
    }
    
}