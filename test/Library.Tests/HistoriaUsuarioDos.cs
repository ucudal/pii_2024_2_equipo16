namespace Library.Tests;
using Library;
public class HistoriaUsuarioDos
{
    
    /// <summary>
    /// Este test comprueba que se muestren los ataques disponibles para que el Pokemon pueda usar por turno.
    /// Es un borrador de la historia de usuario 2.
    /// </summary>
    [Test]
    public void AtaquesEspecialesPorTurno()
    {
        Pokemon pikachu = new Pokemon("Pikachu", new Electrico(), 100);
        
        // Agregar ataques al Pokémon
        Ataque ataqueNormal1 = new Ataque("Impactrueno", new Electrico(), 50, false);
        Ataque ataqueNormal2 = new Ataque("Chispa", new Electrico(), 30, false);
        Ataque ataqueEspecial1 = new Ataque("Rayo", new Electrico(), 80, true);
        Ataque ataqueEspecial2 = new Ataque("Trueno", new Electrico(), 100, true);

        pikachu.Ataques.Add(ataqueNormal1);
        pikachu.Ataques.Add(ataqueNormal2);
        pikachu.Ataques.Add(ataqueEspecial1);
        pikachu.Ataques.Add(ataqueEspecial2);

        // Act y Assert en el Turno 1 (todos los ataques deberían estar disponibles)
        List<Ataque> ataquesDisponiblesTurno1 = pikachu.ObtenerAtaquesDisponibles();
        Assert.Contains(ataqueNormal1, ataquesDisponiblesTurno1);
        Assert.Contains(ataqueNormal2, ataquesDisponiblesTurno1);
        Assert.Contains(ataqueEspecial1, ataquesDisponiblesTurno1);
        Assert.Contains(ataqueEspecial2, ataquesDisponiblesTurno1);

        // Usar un ataque especial en el Turno 1
        pikachu.UsarAtaque(2, new Pokemon("Charmander", new Fuego(), 100)); // Usa ataque especial "Rayo"

        // Act y Assert en el Turno 2 (solo ataques normales deberían estar disponibles)
        List<Ataque> ataquesDisponiblesTurno2 = pikachu.ObtenerAtaquesDisponibles();
        List<Ataque> pruebaAtaques = new List<Ataque>();
        pruebaAtaques.Add(ataqueNormal1);
        pruebaAtaques.Add(ataqueNormal2);
        Assert.That(pruebaAtaques, Is.EqualTo(ataquesDisponiblesTurno2)); //Se comprueba que el único ataque disponible es el normal.
        

        // Usar un ataque normal en el Turno 2
        pikachu.UsarAtaque(0, new Pokemon("Charmander", new Fuego(), 100)); // Usa ataque normal "Impactrueno"

        // Act y Assert en el Turno 3 (los ataques especiales deberían estar disponibles de nuevo)
        List<Ataque> ataquesDisponiblesTurno3 = pikachu.ObtenerAtaquesDisponibles();
        Assert.Contains(ataqueNormal1, ataquesDisponiblesTurno3);
        Assert.Contains(ataqueNormal2, ataquesDisponiblesTurno3);
        Assert.Contains(ataqueEspecial1, ataquesDisponiblesTurno3);
        Assert.Contains(ataqueEspecial2, ataquesDisponiblesTurno3);
    }

    
}
