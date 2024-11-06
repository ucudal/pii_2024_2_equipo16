namespace Library.Tests;

public class HistoriaUsuarioUno
{
    [Test]
    public void PokemonsSeleccionadosSeMuestranEnPantalla()
    {
        CatalogoPokemons catalogo = new CatalogoPokemons();
        JugadorPrincipal jugador1 = new JugadorPrincipal("Ana", new CatalogoPokemons());
        jugador1.MostrarCatalogo(catalogo);
        jugador1.ElegirDelCatalogo(1);
        jugador1.ElegirDelCatalogo(5);
        jugador1.ElegirDelCatalogo(7);
        jugador1.ElegirDelCatalogo(9);
        jugador1.ElegirDelCatalogo(12);
        jugador1.ElegirDelCatalogo(14);
        jugador1.MostrarEquipo();

        string resultado = $"Squirtle, Agua, " +
                           $"Charmander, Fuego, " +
                           $"Articuno, Hielo, " +
                           $"Bulbasaur, Planta, " +
                           $"Pupitar, Roca, " +
                           $"Rhyhorn, Tierra, ";
        
        Assert.That(jugador1.MostrarEquipo(), Is.EqualTo(resultado));
        Assert.That(6, Is.EqualTo(jugador1.EquipoPokemons.Count));
    }
}