namespace Library;

    /// <summary>
    /// Esta clase hereda de la interfaz, define todas las características de los personajes de la batalla.
    /// </summary>
    public class Pokemon: IPokemon
    {
        public string Nombre { get; set; }                  //Nombre del pokémon
        public ITipo TipoPokemon { get; set; }              //Tipo del pokémon
        public double VidaActual { get; set; }              //Vida del pokémon
        public double VidaTotal {get; set;}
        public double Ataque { get; set; }                  //Valor de ataque del pokémon
        public double Defensa { get; set; }                 //Valor de defensa del pokémon
        public double AtaqueEspecial { get; set; }          //Valor de ataque especial del pokémon
        public double DefensaEspecial { get; set; }         //Valor de defensa del pokémon
    
        public List<Ataque> Ataques {get; set;}
        public string Estado { get; set; }
        public IEfectos? EfectoActivo { get; set; }
        public bool PuedeAtacar { get; set;}
        public int turnoContadorEspecial { get; set; }

        public Pokemon(string nombre, ITipo tipo, double vidaTotal)
            {
                Nombre = nombre;
                TipoPokemon = tipo;
                VidaActual = vidaTotal;
                VidaTotal = vidaTotal;
                Ataques = new List<Ataque>();
                turnoContadorEspecial = 0;
            }

        /// <summary>
        /// Realiza un ataque a un pokémon enemigo
        /// </summary>
        /// <param name="indiceAtaque"></param>
        /// <param name="enemigo"></param>
        public string UsarAtaque(int indiceAtaque, IPokemon enemigo)           
        {
            Ataque ataque = Ataques[indiceAtaque];
            if (ataque.EsEspecial && turnoContadorEspecial % 2 != 0)
            {
                return "El ataque especial no está disponible este turno.";
            }
            double dano = ataque.CalcularDaño(this, enemigo);
            enemigo.RecibirDaño(dano);
            turnoContadorEspecial++;
        
            return $"{Nombre} usó {ataque.Nombre} y causó {dano} puntos de daño.";
        }
        
        /// <summary>
        /// Recibe daño del pokémon enemigo
        /// </summary>
        /// <param name="dano"></param>
        public void RecibirDaño(double dano)          
        {
            VidaActual -= dano;
            if (VidaActual <0)
            {
                VidaActual = 0;
            }
        }
        
        /// <summary>
        /// Muestra la vida actual sobre la vida total del pokémon
        /// </summary>
        /// <returns></returns>
        public string MostrarVida()
        {
            return $"{VidaActual}/{VidaTotal}";
        }

        public void AtaquesPorTipo()
        {
            CatalogoAtaques catalogo = new CatalogoAtaques();
            foreach (Ataque ataque in catalogo.ataques)
            {
                if (ataque.TipoAtaque.NombreTipo == TipoPokemon.NombreTipo)
                {
                    Ataques.Add(ataque);
                }
            } 
        }
        
        public List<Ataque> ObtenerAtaquesDisponibles()
        {
            if (turnoContadorEspecial % 2 == 0)
            {
                return Ataques; // Todos los ataques están disponibles cada dos turnos
            }
            else
            {
                // Solo devuelve ataques no especiales en turnos alternos
                return Ataques.Where(ataque => !ataque.EsEspecial).ToList();
            }
        }

    }
