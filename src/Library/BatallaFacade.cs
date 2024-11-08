namespace Library
{   
    /*
    En la fachada vemos los métodos de las clases implementados.
    Acá se crean los jugadores, se les agregan los pokemones y los ataques respectivamente.
    Además, llama a las funciones necesarias para poder realizar ataques entre jugadores.
    Todo esto después será utilizado en el Program.
    */
    public class BatallaFacade
    {
        private JugadorPrincipal jugador1;
        private JugadorPrincipal jugador2;
        private int contadorTurnos; // Contador de turnos
        private bool jugador1Ataco; // Indicador de que el jugador 1 atacó en este turno
        private bool jugador2Ataco; // Indicador de que el jugador 2 atacó en este turno
        public bool BatallaEnCurso { get; private set; }
        public BatallaFacade(string nombreJugador1, string nombreJugador2)
        {
            jugador1 = new JugadorPrincipal(nombreJugador1); //El constructor toma como parámetro a los rivales de la partida
            jugador2 = new JugadorPrincipal(nombreJugador2);
            contadorTurnos = 1; // Inicializamos el contador de turnos en 1
            jugador1Ataco = false; // Inicializamos en falso, porque aún no ha atacado
            jugador2Ataco = false; // Inicializamos en falso, porque aún no ha atacado
            BatallaEnCurso = true;
        }

        //Este método es utilizado para agregar Pokemones a la lista de opciones del jugador. Para poder 
        //hacer eso verifica que quien lo agrega es el jugador mismo y no es contrario.
        public void AgregarPokemonAJugador(string nombreJugador, Pokemon pokemon)
        {
            if (jugador1.NombreJugador == nombreJugador) 
            {
                jugador1.EquipoPokemons.Add(pokemon);
            }
            else if (jugador2.NombreJugador == nombreJugador)
            {
                jugador2.EquipoPokemons.Add(pokemon);
            }
        }

        //Toma como parámetro el pokemon elegido y le agrega un ataque del programa.
        public void AgregarAtaqueAPokemon(Pokemon pokemon, Ataque ataque)
        {
            pokemon.Ataques.Add(ataque);
        }

        public void IniciarBatalla() //Muestra el inicio del juego, especificando el nombre del jugador y el pokemon elegido.
        {
            Console.WriteLine($"{jugador1.NombreJugador} comienza la batalla con {jugador1.ElegirPokemon(0).Nombre}");
            Console.WriteLine($"{jugador2.NombreJugador} comienza la batalla con {jugador2.ElegirPokemon(0).Nombre}");
            Console.WriteLine($"¡La batalla ha comenzado! Turno {contadorTurnos}.");
        }

        // Mediante este método, toma como parámetro al jugador (ya que es quien elige el ataque y quien lo usa), y el ataque elegido de la lista.
        // Luego devuelve la vida del pokemon atacado.
        public void RealizarAtaque(string nombreJugador, int indiceAtaque)
        {
            if (jugador1.NombreJugador == nombreJugador)
            {
                jugador1.ElegirAtaque(jugador1.PokemonActual, jugador2.PokemonActual, indiceAtaque);
                Console.WriteLine($"La vida de {jugador2.ElegirPokemon(0).Nombre} es {jugador2.ElegirPokemon(0).MostrarVida()}");
                jugador1Ataco = true; // Indicamos que el jugador 1 atacó
            }
            else if (jugador2.NombreJugador == nombreJugador)
            {
                jugador2.ElegirAtaque(jugador2.ElegirPokemon(0), jugador1.ElegirPokemon(0), indiceAtaque);
                Console.WriteLine($"La vida de {jugador1.ElegirPokemon(0).Nombre} es {jugador1.ElegirPokemon(0).MostrarVida()}");
                jugador2Ataco = true; // Indicamos que el jugador 2 atacó
            }

            // Verificamos si ambos jugadores ya han atacado para completar el turno
            if (jugador1Ataco && jugador2Ataco)
            {
                contadorTurnos++; // Incrementamos el turno después de que ambos han atacado
                Console.WriteLine($"¡El turno {contadorTurnos - 1} ha finalizado!");
                Console.WriteLine($"Comienza el turno {contadorTurnos}.");
                jugador1Ataco = false; // Reseteamos el estado para el próximo turno
                jugador2Ataco = false; // Reseteamos el estado para el próximo turno

                VerificarGanador();
            }
        }

        public string VerificarGanador()
        {
            if (jugador1.PokemonesDerrotados())
            {
                return $"{jugador1.NombreJugador} ha sido derrotado " +
                                  $"{jugador2.NombreJugador} GANÓ";
                BatallaEnCurso = false;
            }
            else if (jugador2.PokemonesDerrotados())
            {
                return $"{jugador2.NombreJugador} ha sido derrotado" +
                                  $"{jugador1.NombreJugador} GANÓ";
                BatallaEnCurso = false;
            }
            else
            {
                return "La batalla continúa";
                
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

        // Método para obtener el turno actual
        public int ObtenerTurnoActual()
        {
            return contadorTurnos;
        }

        
        /// <summary>
        /// Ejecuta el cambio de Pokemon y gestiona el cambio de turno.
        /// </summary>
        /// <param name="nombreJugador"></param>
        /// <param name="indicePokemonACambiar"></param>
        public void CambiarPokemon(string nombreJugador, int indicePokemonACambiar)
        {
            if (jugador1.NombreJugador == nombreJugador)
            {
                if (indicePokemonACambiar >= 0 && indicePokemonACambiar < jugador1.EquipoPokemons.Count)
                {
                    jugador1.CambiarPokemonBatalla(indicePokemonACambiar);
                    Console.WriteLine($"{jugador1.NombreJugador} ha cambiado de pokemon");
                    jugador1.TurnoActual = false;      // el jugador pierde el turno al cambiar de pokémon
                }
                else
                {
                    Console.WriteLine("Índice no válido");
                }
            }
            else if (jugador2.NombreJugador == nombreJugador)
            {
                if (indicePokemonACambiar >= 0 && indicePokemonACambiar < jugador2.EquipoPokemons.Count)
                {
                    jugador2.CambiarPokemonBatalla(indicePokemonACambiar);
                    Console.WriteLine($"{jugador2.NombreJugador} ha cambiado de pokemon");
                    jugador2.TurnoActual = false;
                }  
                else
                {
                    Console.WriteLine("Índice no válido");
                }
            }
        }
        
        /// <summary>
        /// Ejecutar el cambio de Pokémon y gestionar el turno
        /// </summary>
        public void CambiaPokemon(JugadorPrincipal jugador, int indice)
        {
            jugador.CambiarPokemonBatalla(indice);
            VerificarFinTurno(jugador);
        }

        /// <summary>
        /// Verificar si se pierde el turno después de una acción
        /// </summary>
        private void VerificarFinTurno(JugadorPrincipal jugador)
        {
            if (!jugador.TurnoActual)
            {
                Console.WriteLine($"{jugador.NombreJugador} ha perdido su turno al cambiar de Pokémon.");
            }
        }
        

        /// <summary>
        /// Gestiona el turno actual
        /// </summary>
        public bool BatallaSigue()
        {
            if (jugador1.PokemonesDerrotados() || jugador2.PokemonesDerrotados())
            {
                return BatallaEnCurso = false;
            }
            
            return BatallaEnCurso = true;
        }
    }
}