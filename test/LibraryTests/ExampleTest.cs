using Library;

namespace LibraryTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ElfoCuracion()
    {
        Personaje herido = new Personaje("EnanoLider", 100);
        herido.Vida = 5; // simulamos como que le sacaron vida.

        Personaje elfoBase = new Personaje("ElfoDoctor", 100);
        Elfo elfo = new Elfo(elfoBase);
        
        elfo.Curar(herido);
        
        Assert.That(herido.Vida, Is.EqualTo(herido.VidaMaxima));
    }

    //public void AtquedelEnano()
   // {
        //Personaje elfoBase = new Personaje("ElfoDoctor", 100);
       // Elfo elfo = new Elfo(elfoBase);
        
       // Personaje enanoEnojado = new Personaje("EnanoLider", 100);
       // Enano enano = new Enano(enanoEnojado);
        
      //  enano.AtaqueTemperamental(elfoBase);
   // }
}