namespace Test;
using Mahlzeit;

public class Tests
{
    Pizzeria daToni;
    Bratwurststand BrunosImbiss;
    Kaffeehaus zumKirchberg;
    [SetUp]
    public void Setup()
    {
        daToni = new Pizzeria();
        BrunosImbiss = new Bratwurststand();
        zumKirchberg = new Kaffeehaus();
        
        daToni.MahlzeitLiefern();
        BrunosImbiss.MahlzeitLiefern();
        zumKirchberg.MahlzeitLiefern();
    }

    [Test]
    public void Pizzatest()
    {
        Assert.That(daToni.mahlzeit.GetType().Equals(typeof(Pizza)));
    }
    [Test]
    public void Kaffeetest()
    {
        Assert.That(zumKirchberg.mahlzeit.GetType().Equals(typeof(Kaffee)));
    }

    [Test]
    public void Bratwursttest()
    {
        Assert.That(BrunosImbiss.mahlzeit.GetType().Equals(typeof(Bratwurst)));
    }
}

// Easter Egg for Macho :)