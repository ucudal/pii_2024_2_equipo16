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
        private int turnoContadorEspecial; //Contador de turnos para ataques especiales
        public Pokemon(string nombre, ITipo tipo, double vidaTotal)
            {
                Nombre = nombre;
                TipoPokemon = tipo;
                VidaActual = vidaTotal;
                VidaTotal = vidaTotal;
                Ataques = new List<Ataque>();
                turnoContadorEspecial = 0;
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

        public string VerAtaques()
        {
            string cadenaAtaques = "";
            foreach (Ataque ataque in Ataques)
            {
                cadenaAtaques += $"Nombre: {ataque.Nombre} Tipo: {ataque.TipoAtaque} Daño: {ataque.DañoBase}\n";
            }

            return cadenaAtaques;
        }
        public string AgregarAtaque(Ataque ataque)
        {
            if (Ataques.Contains(ataque))
            {
                return $"{ataque.Nombre} ya agregado a la lista de ataques";
            }
            else
            {
                Ataques.Add(ataque);
                return $"{ataque.Nombre} agregado correctamente a la lista";
            }
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
    }
