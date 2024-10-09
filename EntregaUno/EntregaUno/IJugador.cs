namespace EntregaUno;

public interface IJugador
{
    public string NombreJugador { get; set; }
    public List<IPokemon> Pokemon { get; set; }
    public bool TurnoActuar { get; set; }
    public void ElegirPokemon();
    public void ElegirAtaque();
    public bool MostrarTurno();
}