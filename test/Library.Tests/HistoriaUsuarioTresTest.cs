namespace Library.Tests;

public class HistoriaUsuarioTresTest
{
    public CatalogoPokemons catalogo;
    public JugadorPrincipal jugador;
    public CatalogoAtaques ataques;

    [SetUp]
    public void SetUp()
    {
        catalogo = new CatalogoPokemons();
        jugador = new JugadorPrincipal("Ben", catalogo,ataques);
    }
    
}