namespace EntregaUno;

    public class Pokemon: IPokemon
    {
        public string Nombre { get; set; }                  //Nombre del pokémon
        public ITipo TipoPokemon { get; set; }              //Tipo del pokémon
        public double VidaActual { get; set; }                    //Vida del pokémon
        public double VidaTotal {get; set;}
        public double Ataque { get; set; }                  //Valor de ataque del pokémon
        public double Defensa { get; set; }                 //Valor de defensa del pokémon
        public double AtaqueEspecial { get; set; }          //Valor de ataque especial del pokémon
        public double DefensaEspecial { get; set; }         //Valor de defensa del pokémon
    
        public List<Ataque> Ataques {get; set;}

        public Pokemon(string nombre, ITipo tipo, double vidaTotal)
        {
            Nombre = nombre;
            TipoPokemon = tipo;
            VidaActual = vidaTotal;
            VidaTotal = vidaTotal;
            Ataques = new List<Ataque>();
        }

        public void UsarAtaque(int indiceAtaque, IPokemon enemigo)           //Método para realizar un ataque
        {
            Ataque ataque = Ataques[indiceAtaque];
            double daño = ataque.CalcularDaño(this, enemigo);
            enemigo.RecibirDaño(daño);
        } 
        public void RecibirDaño(double dano)          //Método para recibir daño del pokémon enemigo
        {
            VidaActual -= dano;
            if (VidaActual <0)
            {
                VidaActual = 0;
            }
        }
        public string MostrarVida()
        {
            return $"{VidaActual}/{VidaTotal}";
        } 
    }
