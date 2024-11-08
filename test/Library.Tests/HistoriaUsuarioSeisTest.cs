namespace Library.Tests;

public class HistoriaUsuarioSeisTest
{
    public CatalogoPokemons CatalogoPokemons;
    public JugadorPrincipal jugador;
    public JugadorPrincipal jugador2;
    private BatallaFacade batalla;
    
    [SetUp]
    public void SetUp()
    {
        /*CatalogoPokemons = new CatalogoPokemons();
        jugador = new JugadorPrincipal("Asia");
        jugador2 = new JugadorPrincipal("Robert");
        batalla = new BatallaFacade(jugador.NombreJugador, jugador2.NombreJugador);
        
        batalla.AgregarPokemonAJugador(jugador.NombreJugador,jugador.ElegirDelCatalogo(5));
        batalla.AgregarPokemonAJugador(jugador.NombreJugador, jugador.ElegirDelCatalogo(6));
        batalla.AgregarPokemonAJugador(jugador.NombreJugador,jugador.ElegirDelCatalogo(7));
        batalla.AgregarPokemonAJugador(jugador.NombreJugador, jugador.ElegirDelCatalogo(8));
        batalla.AgregarPokemonAJugador(jugador.NombreJugador,jugador.ElegirDelCatalogo(10));
        batalla.AgregarPokemonAJugador(jugador.NombreJugador,jugador.ElegirDelCatalogo(12));

        batalla.AgregarPokemonAJugador(jugador2.NombreJugador,jugador2.ElegirDelCatalogo(1));
        batalla.AgregarPokemonAJugador(jugador2.NombreJugador, jugador2.ElegirDelCatalogo(5));
        batalla.AgregarPokemonAJugador(jugador2.NombreJugador,jugador2.ElegirDelCatalogo(9));
        batalla.AgregarPokemonAJugador(jugador2.NombreJugador, jugador2.ElegirDelCatalogo(10));
        batalla.AgregarPokemonAJugador(jugador2.NombreJugador,jugador2.ElegirDelCatalogo(11));
        batalla.AgregarPokemonAJugador(jugador2.NombreJugador,jugador2.ElegirDelCatalogo(14));
        */

        jugador = new JugadorPrincipal("Juan");
        jugador2 = new JugadorPrincipal("Martina");

        jugador.ElegirDelCatalogo(2); //Elige a Squirtle
        jugador.ElegirDelCatalogo(5); //Elige a Bulbasaur

        jugador2.ElegirDelCatalogo(4); //Elige a Charmander.
        jugador2.ElegirDelCatalogo(6); //Elige a Pidgey.

        batalla = new BatallaFacade(jugador.NombreJugador, jugador2.NombreJugador);
    }

    [Test]
    public void DerrotaCuandoTotalPokemonsVidaCero()
    {
        foreach (IPokemon pokemon in jugador2.EquipoPokemons)
        {
            pokemon.VidaActual = 0; //Forzamos a que todos los pokemones del equipo estén derrotados.
        }

        batalla.VerificarGanador();
        
        Assert.IsFalse(batalla.BatallaSigue());

    }

    [Test]
    public void MensajeGanador()
    {
        string ganador = batalla.VerificarGanador();

        string resultadoJ2 = $"{jugador.NombreJugador} ha sido derrotado " +
                           $"{jugador2.NombreJugador} GANÓ";
        
        Assert.That(ganador, Is.EqualTo(resultadoJ2));
    }
}