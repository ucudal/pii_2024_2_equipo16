namespace EntregaUno;

// Esta interfaz define las acciones que el jugador podrá realizar previamente y durante la batalla
public interface IJugador
{
    public string NombreJugador { get; set; }            //Nombre del juagdor
    public List<IPokemon> Pokemon { get; set; }         //Lista de pokemones que el jugador seleccionará
    public bool TurnoActuar { get; set; }               //Muestra si es el turno del jugador
    public void ElegirPokemon();                       //Método para que el jugador elija el pokemon con el que quiere atacar
    public void ElegirAtaque();                        //Método para elegir el ataque del pókemon seleccionado
    public bool MostrarTurno();                        //Método que devuelve un valor booleano con el turno correspondiente al jugador
}