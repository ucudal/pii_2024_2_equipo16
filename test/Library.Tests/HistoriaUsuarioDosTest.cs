namespace Library.Tests;

public class HistoriaUsuarioDosTest
{
    public CatalogoPokemons catalogo;
    public JugadorPrincipal jugador;
    public JugadorPrincipal jugador2;
        
    [SetUp]
    public void SetUp()
    {
        catalogo = new CatalogoPokemons();
        jugador = new JugadorPrincipal("Dan");
        jugador2 = new JugadorPrincipal("Pepe");
        
        jugador.MostrarCatalogo();
        jugador.ElegirDelCatalogo(2);
        jugador.ElegirDelCatalogo(4);
        jugador.ElegirDelCatalogo(5);
        jugador.ElegirDelCatalogo(8);
        jugador.ElegirDelCatalogo(9);
        jugador.ElegirDelCatalogo(13);
        jugador.MostrarEquipo();
        
        jugador2.MostrarCatalogo();
        jugador2.ElegirDelCatalogo(2);
        jugador2.ElegirDelCatalogo(4);
        jugador2.ElegirDelCatalogo(5);
        jugador2.ElegirDelCatalogo(8);
        jugador2.ElegirDelCatalogo(9);
        jugador2.ElegirDelCatalogo(13);
        jugador2.MostrarEquipo();
    }
    
    [Test]
    public void AtaquesDisponiblesPrimerTurno()
    {
        //Estamos en el primer turno.
        //Tenemos q ver q se muestre toda la lista de ataques de tipo Agua (que es la del tipo del Pokemon).
        string resultado = $"1. Nombre: Burbuja Tipo: Agua Daño: 25 Es especial: False.\n" +
                           $"2. Nombre: Pistola de agua Tipo: Agua Daño: 6 Es especial: False.\n" +
                           $"3. Nombre: Acua Jet Tipo: Agua Daño: 25 Es especial: True.\n" +
                           $"4. Nombre: Hidrobomba Tipo: Agua Daño: 90 Es especial: True.\n";
        
        Assert.That(jugador.MostrarAtaquesDisponibles(0), Is.EqualTo(resultado));
    }

    [Test]
    public void AtaquesDisponiblesSegundoTurno()
    {
        IPokemon pokemon = jugador.ElegirPokemon(2);
    }
}