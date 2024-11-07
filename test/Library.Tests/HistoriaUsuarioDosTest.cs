namespace Library.Tests;

public class HistoriaUsuarioDosTest
{
    private CatalogoPokemons catalogo;
    private JugadorPrincipal jugador;
    private CatalogoAtaques ataques;
    private JugadorPrincipal jugador2;
        
    [SetUp]
    public void SetUp()
    {
        catalogo = new CatalogoPokemons();
        ataques = new CatalogoAtaques();
        jugador = new JugadorPrincipal("Dan", catalogo, ataques);
        jugador2 = new JugadorPrincipal("Pepe", catalogo, ataques);
        
        jugador.MostrarCatalogo(catalogo);
        jugador.ElegirDelCatalogo(2);
        jugador.ElegirDelCatalogo(4);
        jugador.ElegirDelCatalogo(5);
        jugador.ElegirDelCatalogo(8);
        jugador.ElegirDelCatalogo(9);
        jugador.ElegirDelCatalogo(13);
        jugador.MostrarEquipo();
        
        jugador2.MostrarCatalogo(catalogo);
        jugador2.ElegirDelCatalogo(2);
        jugador2.ElegirDelCatalogo(4);
        jugador2.ElegirDelCatalogo(5);
        jugador2.ElegirDelCatalogo(8);
        jugador2.ElegirDelCatalogo(9);
        jugador2.ElegirDelCatalogo(13);
        jugador2.MostrarEquipo();
    }
    
    [Test]
    public void AtaquesDisponibles()
    {
        string resultado = "1. Burbuja.\n2. Pistola de agua.\n3. Acua Jet.\n4. Hidrobomba.\n";
        
        Assert.That(jugador.MostrarAtaquesDisponibles(0), Is.EqualTo(resultado));
    }

    [Test]
    public void AtaquesEspecialesCadaDosTurnos()
    {
        jugador.MostrarAtaquesDisponibles(2);

        IPokemon pokemon = jugador.ElegirPokemon(2);
        IPokemon pokemonEnemigo = jugador2.ElegirPokemon(4);
        jugador.ElegirAtaque(pokemon, pokemonEnemigo, 2);
    }
}