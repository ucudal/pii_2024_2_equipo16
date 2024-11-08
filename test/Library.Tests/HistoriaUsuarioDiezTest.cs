namespace Library.Tests;

public class HistoriaUsuarioDiezTest
{
    public JugadorPrincipal entrenador;
    public JugadorPrincipal entrenador2;
    public BatallaFacade batalla;
    
    [SetUp]
    public void SetUp()
    {
        entrenador = new JugadorPrincipal("Mateo");
        entrenador2 = new JugadorPrincipal("Belén");
        batalla = new BatallaFacade(entrenador.NombreJugador, entrenador2.NombreJugador);
        
    }

    [Test]
    public void MostrarListaDeEsperaPorOponente()
    {
        batalla.ListaDeEspera(entrenador);
        batalla.ListaDeEspera(entrenador2);

        string esperado = batalla.MostrarListaDeEspera();

        string mensaje = "Mateo\nBelén\n";
        
        Assert.That(mensaje, Is.EqualTo(esperado));
    }
}