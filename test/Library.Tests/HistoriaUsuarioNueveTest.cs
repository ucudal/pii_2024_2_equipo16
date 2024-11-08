namespace Library.Tests;

public class HistoriaUsuarioNueveTest
{
    public JugadorPrincipal entrenador;
    public JugadorPrincipal entrenador2;
    public BatallaFacade batalla;
    
    [SetUp]
    public void SetUp()
    {
        entrenador = new JugadorPrincipal("Martin");
        entrenador2 = new JugadorPrincipal("Clara");
        batalla = new BatallaFacade(entrenador.NombreJugador, entrenador2.NombreJugador);
        
    }

    [Test]
    public void ListaDeEsperaJugadores()
    {
        string esperado = batalla.ListaDeEspera(entrenador);

        string mensaje = $"{entrenador.NombreJugador} fue agregado a la lista de espera";
        
        Assert.That(mensaje, Is.EqualTo(esperado));
    }
}