namespace EntregaUno;

// Esta interfaz define las acciones que el jugador podrá realizar previamente y durante la batalla
public interface IJugador
{
    public string NombreJugador { get; set; }           //Nombre del juagdor
    public List<IPokemon> Pokemon { get; set; }         //Lista de pokemones disponibles para el jugador
    public bool TurnoActuar { get; set; }               //Indica si es el turno del jugador
    public void ElegirPokemon();                        //Método para que el jugador elija el pokemon con el que quiere atacar
    public void ElegirAtaque();                         //Método para elegir el ataque del pokémon seleccionado
    public bool MostrarTurno();                         //Método que devuelve un valor booleano con el turno correspondiente al jugador
}