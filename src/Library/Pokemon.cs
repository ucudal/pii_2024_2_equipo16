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
        
        public Pokemon(string nombre, ITipo tipo, double vidaTotal)
            {
                Nombre = nombre;
                TipoPokemon = tipo;
                VidaActual = vidaTotal;
                VidaTotal = vidaTotal;
                Ataques = new List<Ataque>();
            }

        /// <summary>
        /// Realiza un ataque a un pokémon enemigo
        /// </summary>
        /// <param name="indiceAtaque"></param>
        /// <param name="enemigo"></param>
        public void UsarAtaque(int indiceAtaque, IPokemon enemigo)           
        {
            Ataque ataque = Ataques[indiceAtaque];
            double dano = ataque.CalcularDaño(this, enemigo);
            enemigo.RecibirDaño(dano);
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
