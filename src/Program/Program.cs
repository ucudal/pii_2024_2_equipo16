namespace EntregaUno;
using Library;

class Program
{
    static void Main(string[] args)
    {
        // Crear jugadores
        JugadorPrincipal jugador1 = new JugadorPrincipal("jugador1");
        JugadorPrincipal jugador2 = new JugadorPrincipal("jugador2");

        // Crear Pokémons
        Pokemon pikachu = new Pokemon("Pikachu", new Electrico(), 100);
        Pokemon squirtle = new Pokemon("Squirtle", new Agua(), 100);

        // Añadir ataques
        pikachu.Ataques.Add(new Ataque("Impactrueno", new Electrico(), 50, false));
        squirtle.Ataques.Add(new Ataque("Pistola Agua", new Agua(), 40, false));

        // Añadir Pokémons al equipo
        jugador1.EquipoPokemon.Add(pikachu);
        jugador2.EquipoPokemon.Add(squirtle);

        // Inicio de batalla
        Console.WriteLine($"{jugador1.NombreJugador} comienza la batalla con {jugador1.EquipoPokemon[0].Nombre}");
        Console.WriteLine($"{jugador2.NombreJugador} comienza la batalla con {jugador2.EquipoPokemon[0].Nombre}");

        // Turnos simulados
        jugador1.ElegirAtaque(pikachu,squirtle, 0);
        Console.WriteLine($"La vida de {squirtle.Nombre} es {squirtle.MostrarVida()}");
    }

}

