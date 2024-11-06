namespace Library;
    /// <summary>
    /// Esta clase representa al usuario, quien hará uso de los distintos pokemones para su batalla
    /// </summary>
    public class JugadorPrincipal : IJugador
    {
        public string NombreJugador { get; set; }
        public List<IPokemon> EquipoPokemons { get; set; } 
        public bool TurnoActual { get; set; }
        private CatalogoPokemons Catalogo { get; set; }

        public JugadorPrincipal(string nombre, CatalogoPokemons catalogo)
        {
            NombreJugador = nombre;
            EquipoPokemons = new List<IPokemon>();
            TurnoActual = true;
            Catalogo = catalogo;
        }
        
        /// <summary>
        /// Durante la batalla, podrá elegir un pokémon por su índice
        /// </summary>
        /// <param name="indice">índice del pokémon elegido para la batalla</param>
        /// <returns>Pokémon del equipo elegido para la batalla</returns>
        /// <exception cref="ArgumentOutOfRangeException">Se tira una excepción cuando el índice no entra dentro del rango
        /// de los integrantes del equipo</exception>
        public IPokemon ElegirPokemon(int indice)
        {
            try
            {
                if (indice < 0 || indice >= EquipoPokemons.Count || indice > 5)
                {
                    throw new ArgumentOutOfRangeException("Debe ingresar un valor entre 0 y "+ (EquipoPokemons.Count - 1));
                }
                
                return EquipoPokemons[indice];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Debe ingresar un valor entre 0 y "+ (EquipoPokemons.Count - 1));
            }
            finally
            {
                Console.WriteLine("Gracias por jugar!");
            }
            return null;
        }

        /// <summary>
        /// El pokémon a atacar elige un ataque para 
        /// </summary>
        /// <param name="pokemon"></param>
        /// <param name="enemigo"></param>
        /// <param name="indiceAtaque"></param>
        public void ElegirAtaque(IPokemon pokemon, IPokemon enemigo, int indiceAtaque)
        {
            pokemon.UsarAtaque(indiceAtaque, enemigo); // Supongamos que elegimos un ataque del Pokémon
        }

        /// <summary>
        /// Muestra el turno del pokémon en la batalla
        /// </summary>
        /// <returns>Turno actual</returns>
        public bool MostrarTurno()
        {
            return TurnoActual;
        }

        /// <summary>
        /// Muestra el catálogo con todos los pokémones disponibles para formar un equipo
        /// </summary>
        /// <param name="catalogo"></param>
        public void MostrarCatalogo(CatalogoPokemons catalogo)
        {
            catalogo.MostrarCatalogo();
        }

        /// <summary>
        /// Del catálogo elegir 6 pokémons para agregar a su equipo
        /// </summary>
        /// <param name="indice">número de pokémon en la lista del catálogo</param>
        public void ElegirDelCatalogo(int indice)
        {
            int indiceCatalogo = indice - 1;
            if (EquipoPokemons.Count < 6)
            {
                EquipoPokemons.Add(Catalogo.Catalogo[indiceCatalogo]);
            }
            else
            {
                Console.WriteLine("Ya tienes 6 pokémones en tu equipo");
            }
        }
        
        /// <summary>
        /// Muestra el equipo formado
        /// </summary>
        /// <returns>Todos los pokémon del equipo con su nombre y tipo</returns>
        public string MostrarEquipo()
        {
            string cadenaEquipo = "";
            foreach (IPokemon pokemon in EquipoPokemons)
            {
                cadenaEquipo += $"{pokemon.Nombre}, {pokemon.TipoPokemon.NombreTipo}, ";
            }

            return cadenaEquipo;
        }
    }