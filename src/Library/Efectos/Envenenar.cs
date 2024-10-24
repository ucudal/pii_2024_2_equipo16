namespace Library;

public class Envenenar : IEfectos
{
    public string nombreEfecto {get; set;} = "Envenenar";
    private int turnosRestante = 3;                      // Numero de turnos que durara el efecto
    public void AplicarEfecto(IPokemon objetivo)
    {
    objetivo.Estado = "Envenenado";                     // El Pokémon puede seguir atacando
    }
    public void AplicarDañoPorTurno(IPokemon objetivo)
    {
        if(turnosRestante > 0)
        {
            int daño = (int)(objetivo.VidaActual * 0.05);
            objetivo.VidaActual -= daño;
            turnosRestante--;                           // Este va disminuyendo el contador de turnos en 1
        }
    }

}
