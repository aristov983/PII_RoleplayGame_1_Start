namespace Library;

public class MostradorDeAtaques // aca nuestra idea es hacer una clase, que tenga una unica funcionalidad. En este caso mostrar los ataques.
{
    // nuestra idea con esta clase es aplicar SRP.
        // Para ataques con Item
        public void MostrarAtaque(Personaje atacante, Personaje atacado, Item i)
        {
            Console.WriteLine($"-------El {atacante.Nombre} usó {i.Nombre}, el daño es de {i.Ataque} puntos de vida.----------");
            Console.WriteLine($"{atacante.Nombre} atacó a {atacado.Nombre}");
            Console.WriteLine($"El {atacado.Nombre} tiene {atacado.Vida} de vida");
        }

        // Para ataques con uno o varios hechizos
        public void MostrarAtaque(Personaje atacante, Personaje atacado, List<Hechizo> hechizos)
        {
            foreach (var h in hechizos)
            {
                Console.WriteLine($"--- El {atacante.Nombre} uso {h.Nombre}, el daño es de {h.Ataque} puntos de vida------ ");
            }
            Console.WriteLine($"{atacante.Nombre} atacó a {atacado.Nombre}");
            Console.WriteLine($"El {atacado.Nombre} tiene {atacado.Vida} de vida");
        }
    

}