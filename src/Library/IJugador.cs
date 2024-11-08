namespace Library;

/// <summary>
/// Esta interfaz define las acciones que el jugador podrá realizar previamente y durante la batalla
/// </summary>
public interface IJugador
{
    public string NombreJugador { get; set; }           //Nombre del juagdor
    //public List<IPokemon> EquipoPokemon { get; set; }         //Cada jugador tiene una lista de pokemones disponibles para usar durante la partida, sería su "Equipo".
    public List<IPokemon> EquipoPokemons { get; set; }
    public bool TurnoActual { get; set; }               //Mediante este bool se indica si el turno es del jugador o de su oponente.
    public IPokemon PokemonActual { get; set; }
    public IPokemon ElegirPokemon(int indice);                        //Método para que el jugador elija el pokemon con el que quiere atacar
    public void ElegirAtaque(IPokemon pokemon, IPokemon enemigo, int indiceAtaque);                         //Método para elegir el ataque del pokémon seleccionado
    public bool MostrarTurno();                         //Método que devuelve un valor booleano con el turno correspondiente al jugador
    public void MostrarCatalogo();
    public string MostrarAtaquesDisponibles(int indice);
    public Pokemon ElegirDelCatalogo(int indice);
    public string MostrarEquipo();
    public bool PokemonesDerrotados();
}