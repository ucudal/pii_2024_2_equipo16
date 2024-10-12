namespace Library.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAtaqueNormal()
        {
            // Crear jugadores
            JugadorPrincipal jugador1 = new JugadorPrincipal("José");
            JugadorPrincipal jugador2 = new JugadorPrincipal("Gabriel");

            // Crear Pokémons
            Pokemon pikachu = new Pokemon("Pikachu", new Electrico(), 1000);
            Pokemon squirtle = new Pokemon("Squirtle", new Agua(), 1150);

            // Asignar atributos a Pikachu
            pikachu.Ataque = 100;
            pikachu.Defensa = 20;
            pikachu.AtaqueEspecial = 200;
            pikachu.DefensaEspecial = 40;
            pikachu.VidaActual = 1000; // Inicialmente igual a VidaTotal

            // Asignar atributos a Squirtle
            squirtle.Ataque = 90;
            squirtle.Defensa = 35;
            squirtle.AtaqueEspecial = 160;
            squirtle.DefensaEspecial = 65;
            squirtle.VidaActual = 1150; // Inicialmente igual a VidaTotal

            // Añadir ataques
            pikachu.Ataques.Add(new Ataque("Golpe Normal", new Electrico(), 50, false)); // Ataque normal
            pikachu.Ataques.Add(new Ataque("Impactrueno", new Electrico(), 100, true)); // Ataque especial
            squirtle.Ataques.Add(new Ataque("Pistola Agua", new Agua(), 40, false)); // Ataque para posible uso

            // Añadir Pokémons al equipo
            jugador1.EquipoPokemon.Add(pikachu);
            jugador2.EquipoPokemon.Add(squirtle);

            // Mostrar turno
            Console.WriteLine("Turno 1:");
            Console.WriteLine($"{jugador1.NombreJugador} elige atacar con {pikachu.Nombre} a {squirtle.Nombre}");

            // Pikachu ataca a Squirtle con un ataque normal
            jugador1.ElegirAtaque(pikachu, squirtle, 0);
            
            // Verificar la vida de Squirtle después del ataque normal
            double dañoNormal = pikachu.Ataques[0].CalcularDaño(pikachu, squirtle);
            Assert.AreEqual(squirtle.VidaActual, 1150 - dañoNormal);
        }

        [Test]
        public void TestAtaqueEspecialImpactrueno()
        {
            // Crear jugadores
            JugadorPrincipal jugador1 = new JugadorPrincipal("José");
            JugadorPrincipal jugador2 = new JugadorPrincipal("Gabriel");

            // Crear Pokémons
            Pokemon pikachu = new Pokemon("Pikachu", new Electrico(), 1000);
            Pokemon squirtle = new Pokemon("Squirtle", new Agua(), 1150);

            // Asignar atributos a Pikachu
            pikachu.Ataque = 100;
            pikachu.Defensa = 20;
            pikachu.AtaqueEspecial = 200;
            pikachu.DefensaEspecial = 40;
            pikachu.VidaActual = 1000; // Inicialmente igual a VidaTotal

            // Asignar atributos a Squirtle
            squirtle.Ataque = 90;
            squirtle.Defensa = 35;
            squirtle.AtaqueEspecial = 160;
            squirtle.DefensaEspecial = 65;
            squirtle.VidaActual = 1150; // Inicialmente igual a VidaTotal

            // Añadir ataques
            pikachu.Ataques.Add(new Ataque("Golpe Normal", new Electrico(), 50, false)); // Ataque normal
            pikachu.Ataques.Add(new Ataque("Impactrueno", new Electrico(), 100, true)); // Ataque especial
            squirtle.Ataques.Add(new Ataque("Pistola Agua", new Agua(), 40, false)); // Ataque para posible uso

            // Añadir Pokémons al equipo
            jugador1.EquipoPokemon.Add(pikachu);
            jugador2.EquipoPokemon.Add(squirtle);

            // Mostrar turno
            Console.WriteLine("Turno 2:");
            Console.WriteLine($"{jugador1.NombreJugador} elige atacar con {pikachu.Nombre} a {squirtle.Nombre} usando Impactrueno");

            // Pikachu ataca a Squirtle con un ataque especial
            jugador1.ElegirAtaque(pikachu, squirtle, 1);
            
            // Verificar la vida de Squirtle después del ataque especial
            double dañoEspecial = pikachu.Ataques[1].CalcularDaño(pikachu, squirtle);
            Assert.AreEqual(squirtle.VidaActual, 1150 - dañoEspecial);
        }
    }
}