namespace Library.Tests;

public class HistoriaUsuarioTresTest
{
    public CatalogoPokemons catalogo;
    public JugadorPrincipal jugador;
    public JugadorPrincipal jugador2;
    public CatalogoAtaques ataques;

    [SetUp]
    public void SetUp()
    {
        catalogo = new CatalogoPokemons();
        jugador = new JugadorPrincipal("Ben");
        jugador2 = new JugadorPrincipal("Dan");
        
        jugador.MostrarCatalogo();
        jugador.ElegirDelCatalogo(3);
        
        jugador2.ElegirDelCatalogo(5);
    }

    [Test]
    public void ActualizacionDeVidaEnCadaAtaque()
    {
        IPokemon pokemon = jugador.ElegirPokemon(0);

        IPokemon pokemonEnemigo = jugador2.ElegirPokemon(0);
        
        pokemon.AtaquesPorTipo();
        string vidaAntesAtaque = pokemonEnemigo.MostrarVida();
        pokemon.UsarAtaque(0, pokemonEnemigo);
        string vidaDespuesAtaque = pokemonEnemigo.MostrarVida();
        
        Assert.That(vidaAntesAtaque, Is.Not.EqualTo(vidaDespuesAtaque));

        pokemon.UsarAtaque(1, pokemonEnemigo);
        string vidaDespuesSegundoAtaque = pokemonEnemigo.MostrarVida();
        
        Assert.That(vidaDespuesAtaque, Is.Not.EqualTo(vidaDespuesSegundoAtaque));
    }

    [Test]
    public void MostrarVidaEnFormatoNumerico()
    {
        IPokemon pokemon = jugador.ElegirPokemon(0);
        string vida = pokemon.MostrarVida();

        string vidaEsperada = "100/100";
        
        Assert.That(vida, Is.EqualTo(vidaEsperada));
    }
}