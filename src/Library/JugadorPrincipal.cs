namespace Library;
    /// <summary>
    /// Esta clase representa al usuario, quien hará uso de los distintos pokemones para su batalla
    /// </summary>
    public class JugadorPrincipal : IJugador
    {
        public string NombreJugador { get; set; }
        public List<IPokemon> EquipoPokemon { get; set; }
        public bool TurnoActual { get; set; }

        public JugadorPrincipal(string nombre)
        {
            NombreJugador = nombre;
            EquipoPokemon = new List<IPokemon>();
            TurnoActual = true;
        }

        public IPokemon ElegirPokemon()
        {
            // Lógica para que el jugador elija un Pokémon de su equipo.
            return EquipoPokemon[0]; // Ejemplo simple, por defecto elige el primero.
        }

        public void ElegirAtaque(IPokemon pokemon, IPokemon enemigo, int indiceAtaque)
        {
            pokemon.UsarAtaque(indiceAtaque, enemigo); // Supongamos que elegimos un ataque del Pokémon
        }

        public bool MostrarTurno()
        {
            return TurnoActual;
        } 
    }