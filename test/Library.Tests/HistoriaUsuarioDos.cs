//namespace Library.Tests;
//using Library;
/*public class HistoriaUsuarioDos
{
    
    /// <summary>
    /// Este test comprueba que se muestren los ataques disponibles para que el Pokemon pueda usar por turno.
    /// </summary>
    [Test]
    public void AtaquesAgregados()
    {
        Pokemon pikachu = new Pokemon("Pikachu", new Electrico(), 100);

        Ataque ataqueNormal = new Ataque("Ataque Normal", new Electrico(), 20, false);
        Ataque ataqueEspecial = new Ataque("Ataque Especial", new Electrico(), 15, true);
        
        pikachu.AgregarAtaque(ataqueNormal);
        pikachu.AgregarAtaque(ataqueEspecial);

        List<Ataque> ataquesDisponibles1 = pikachu.ObtenerAtaquesDisponibles();
        
        //Al ser el primer turno, se van a poder obtener los dos tipos de ataques que tiene el Pokemon en su lista 
        //Los ataques especiales solo se pueden obtener a cada dos turnos.
        Assert.Contains(ataqueNormal, ataquesDisponibles1);
        Assert.Contains(ataqueEspecial, ataquesDisponibles1);

        // Se prueba si en pantalla se muestra correctamente la lista de ataques.
        string cadenaPrueba = $"Nombre: {ataqueNormal.Nombre} Tipo: {ataqueNormal.TipoAtaque} Daño: {ataqueNormal.DañoBase}\nNombre: {ataqueEspecial.Nombre} Tipo: {ataqueEspecial.TipoAtaque} Daño: {ataqueEspecial.DañoBase}\n";
        Assert.That(pikachu.VerAtaques(), Is.EqualTo(cadenaPrueba));
        
        //Pikachu usa un ataque, indicando un nuevo turno. En este turno ya no debería estar disponible el ataque especial.
        pikachu.UsarAtaque(0, new Pokemon("Charmander", new Fuego(), 100)); // Ataque normal en turno 1
        
        List<Ataque> ataquesDisponiblesTurno2 = pikachu.ObtenerAtaquesDisponibles();
        List<Ataque> pruebaAtaques = new List<Ataque>();
        pruebaAtaques.Add(ataqueNormal);
        Assert.That(pruebaAtaques, Is.EqualTo(ataquesDisponiblesTurno2)); //Se comprueba que el único ataque disponible es el normal.
        

        // Usa otro ataque para cambiar de turno nuevamente
        pikachu.UsarAtaque(0, new Pokemon("Charmander", new Fuego(), 100)); // Ataque normal en turno 2

        
        List<Ataque> ataquesDisponiblesTurno3 = pikachu.ObtenerAtaquesDisponibles();
        
        Assert.Contains(ataqueEspecial, ataquesDisponiblesTurno3); //En este turno sí está disponible el ataque especial.
    }

    
}*/
