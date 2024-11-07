namespace Library.Tests;

public class HistoriaUsuarioUnoTest
{
    public CatalogoPokemons catalogo;
    public JugadorPrincipal jugador1;
    public CatalogoAtaques ataques;

    [SetUp]
    public void SetUp()
    {
        catalogo = new CatalogoPokemons();
        jugador1 = new JugadorPrincipal("Ana");
        
        jugador1.MostrarCatalogo();
        jugador1.ElegirDelCatalogo(1);
        jugador1.ElegirDelCatalogo(5);
        jugador1.ElegirDelCatalogo(7);
        jugador1.ElegirDelCatalogo(9);
        jugador1.ElegirDelCatalogo(12);
        jugador1.ElegirDelCatalogo(14);
        jugador1.MostrarEquipo();
        
    }
    [Test]
    public void PokemonsSeleccionadosSeMuestranEnPantalla()
    {
        string resultado = $"Squirtle, Agua, " +
                           $"Charmander, Fuego, " +
                           $"Articuno, Hielo, " +
                           $"Bulbasaur, Planta, " +
                           $"Pupitar, Roca, " +
                           $"Rhyhorn, Tierra, ";

        Assert.That(jugador1.MostrarEquipo(), Is.EqualTo(resultado));
    }
    
    [Test]
    public void SeleccionarEquipo()
    { 
        Assert.That(6, Is.EqualTo(jugador1.EquipoPokemons.Count));
    }
}