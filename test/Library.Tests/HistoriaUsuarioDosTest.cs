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
    
    //[Test]
    /*public void AtaquesDisponibles()
    {
        string resultado = "1. Burbuja.\n2. Pistola de agua.\n3. Acua Jet.\n4. Hidrobomba.\n";
        
        //Assert.That(jugador.MostrarAtaquesDisponibles(0), Is.EqualTo(resultado));
    }*/

    [Test]
    public void AtaquesEspecialesCadaDosTurnos()
    {
        

        IPokemon pokemon = jugador2.ElegirPokemon(0);
        
        //Estamos en el primer turno.
        //Tenemos q ver q se muestren toda la lista de ataques de tipo Agua (que es la del tipo del Pokemon).
        string ataquesDisponiblesT1 = $"1. Nombre: Burbuja Tipo: Agua Daño: 25 Es especial: False.\n2. Nombre: Pistola de agua Tipo: Agua Daño: 6 Es especial: False.\n3. Nombre: Acua Jet Tipo: Agua Daño: 25 Es especial: True.\n4. Nombre: Hidrobomba Tipo: Agua Daño: 90 Es especial: True.\n5. Nombre: Burbuja Tipo: Agua Daño: 25 Es especial: False.\n6. Nombre: Pistola de agua Tipo: Agua Daño: 6 Es especial: False.\n7. Nombre: Acua Jet Tipo: Agua Daño: 25 Es especial: True.\n";
        Assert.That(ataquesDisponiblesT1, Is.EqualTo(jugador2.MostrarAtaquesDisponibles(0)));
        
    }
}