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
        CatalogoPokemons = new CatalogoPokemons();
        jugador = new JugadorPrincipal("Asia");
        jugador2 = new JugadorPrincipal("Robert");
        batalla = new BatallaFacade(jugador.NombreJugador, jugador2.NombreJugador);
        
        jugador.MostrarCatalogo();
        jugador.ElegirDelCatalogo(5);
        jugador.ElegirDelCatalogo(6);
        jugador.ElegirDelCatalogo(7);
        jugador.ElegirDelCatalogo(8);
        jugador.ElegirDelCatalogo(10);
        jugador.ElegirDelCatalogo(12);
        
        jugador2.MostrarCatalogo();
        jugador2.ElegirDelCatalogo(1);
        jugador2.ElegirDelCatalogo(5);
        jugador2.ElegirDelCatalogo(9);
        jugador2.ElegirDelCatalogo(10);
        jugador2.ElegirDelCatalogo(11);
        jugador2.ElegirDelCatalogo(14);
    }

    [Test]
    public void DerrotaCuandoTotalPokemonsVidaCero()
    {
        batalla.RealizarAtaque(jugador.NombreJugador, 0);
        batalla.RealizarAtaque(jugador2.NombreJugador, 0);
        
        batalla.RealizarAtaque(jugador.NombreJugador, 0);
        batalla.RealizarAtaque(jugador2.NombreJugador, 0);
        
        Assert.That(jugador.PokemonesDerrotados() || jugador2.PokemonesDerrotados(), Is.True);
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