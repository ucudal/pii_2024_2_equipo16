namespace Library
{   /*
    En la fachada vemos los métodos de las clases implementados.
    Acá se crean los jugadores, se les agregan los pokemones y los ataques respectivamente.
    Además, llama a las funciones necesarias para poder realizar ataques entre jugadores.
    Todo esto después será utilizado en el Program.
    */
    public class BatallaFacade
    {
        private JugadorPrincipal jugador1;
        private JugadorPrincipal jugador2;

        public BatallaFacade(string nombreJugador1, string nombreJugador2)
        {
            jugador1 = new JugadorPrincipal(nombreJugador1); //El constructor toma como parámetro a los rivales de la partida
            jugador2 = new JugadorPrincipal(nombreJugador2);
        }

        //Este método es utilizado para agregar Pokemones a la lista de opciones del jugador. Para poder 
        //hacer eso verifica que quien lo agrega es el jugador mismo y no es contrario.
        public void AgregarPokemonAJugador(string nombreJugador, Pokemon pokemon)
        {
            if (jugador1.NombreJugador == nombreJugador) 
            {
                jugador1.EquipoPokemon.Add(pokemon);
            }
            else if (jugador2.NombreJugador == nombreJugador)
            {
                jugador2.EquipoPokemon.Add(pokemon);
            }
        }

        //Toma como parámetro el pokemon elegido y le agrega un ataque del programa.
        public void AgregarAtaqueAPokemon(Pokemon pokemon, Ataque ataque)
        {
            pokemon.Ataques.Add(ataque);
        }

        public void IniciarBatalla() //Muestra el inicio del juego, especificando el nombre del jugador y el pokemon elegido.
        {
            Console.WriteLine($"{jugador1.NombreJugador} comienza la batalla con {jugador1.EquipoPokemon[0].Nombre}");
            Console.WriteLine($"{jugador2.NombreJugador} comienza la batalla con {jugador2.EquipoPokemon[0].Nombre}");
        }


        // Mediante este método, toma como parámetro al jugador (ya que es quien elige el ataque y quien lo usa), y el ataque elegido de la lista.
        // Luego devuelve la vida del pokemon atacado.
        public void RealizarAtaque(string nombreJugador, int indiceAtaque)
        {
            if (jugador1.NombreJugador == nombreJugador)
            {
                jugador1.ElegirAtaque(jugador1.EquipoPokemon[0], jugador2.EquipoPokemon[0], indiceAtaque);
                Console.WriteLine($"La vida de {jugador2.EquipoPokemon[0].Nombre} es {jugador2.EquipoPokemon[0].MostrarVida()}");
            }
            else if (jugador2.NombreJugador == nombreJugador)
            {
                jugador2.ElegirAtaque(jugador2.EquipoPokemon[0], jugador1.EquipoPokemon[0], indiceAtaque);
                Console.WriteLine($"La vida de {jugador1.EquipoPokemon[0].Nombre} es {jugador1.EquipoPokemon[0].MostrarVida()}");
            }
        }

        //Muestra el turno del jugador.
        public bool VerificarTurno(string nombreJugador)
        {
            if (jugador1.NombreJugador == nombreJugador)
            {
                return jugador1.MostrarTurno();
            }
            else if (jugador2.NombreJugador == nombreJugador)
            {
                return jugador2.MostrarTurno();
            }
            return false;
        }
    }
}