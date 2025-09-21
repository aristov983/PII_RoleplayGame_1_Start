namespace Library;

public class LibroDeHechizos
{

    public List<Hechizo> Hechizos = new List<Hechizo>();

    public void AgregarHechizo(Hechizo hechizo)
    {
        Hechizos.Add(hechizo);
    }

    public void QuitarHechizo(Hechizo hechizo)
    {
        Hechizos.Remove(hechizo);
    }
    
}