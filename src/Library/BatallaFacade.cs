namespace Library
{
    public class BatallaFacade
    {
        private JugadorPrincipal jugador1;
        private JugadorPrincipal jugador2;

        public BatallaFacade(string nombreJugador1, string nombreJugador2)
        {
            jugador1 = new JugadorPrincipal(nombreJugador1);
            jugador2 = new JugadorPrincipal(nombreJugador2);
        }

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

        public void AgregarAtaqueAPokemon(Pokemon pokemon, Ataque ataque)
        {
            pokemon.Ataques.Add(ataque);
        }

        public void IniciarBatalla()
        {
            Console.WriteLine($"{jugador1.NombreJugador} comienza la batalla con {jugador1.EquipoPokemon[0].Nombre}");
            Console.WriteLine($"{jugador2.NombreJugador} comienza la batalla con {jugador2.EquipoPokemon[0].Nombre}");
        }

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