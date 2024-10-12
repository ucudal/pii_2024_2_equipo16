namespace Library

{   //Esta clase define que tipo de ataque usará el jugador para atacar a otro pokemon. Contiene un valor booleano que define si es especial o no, y a partir de ahí calculará el daño que le realizará al otro personaje.
    public class Ataque
    {
        public string Nombre { get; set; }
        public ITipo TipoAtaque { get; set; }
        public double DañoBase { get; set; }
        public bool EsEspecial { get; set; }

        public Ataque(string nombre, ITipo tipo, double dañoBase, bool esEspecial) // Cada ataque al que puede acceder el jugador tiene distinto nombre, distinto valor de daño y si es especial o no.
        {
            Nombre = nombre;
            TipoAtaque = tipo;
            DañoBase = dañoBase;
            EsEspecial = esEspecial;
        }

        public double CalcularDaño(IPokemon atacante, IPokemon defensor)
        {
                double dano;

                // Si es un ataque especial, aplicar el ponderador
                if (EsEspecial)
                {
                    double multiplicador = TipoAtaque.Ponderador(defensor.TipoPokemon);
                    dano = DañoBase * multiplicador - defensor.DefensaEspecial;
                }
                else
                {
                    // Si no es especial, el daño se calcula sin ponderador
                    dano = DañoBase - defensor.Defensa;
                }

                // Aseguremos de que el daño no sea negativo
                return Math.Max(dano, 0);
        }
    
    }
      
}

