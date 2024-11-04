namespace Library;

public class Quemar : IEfectos
{
    public string nombreEfecto {get; set;} = "Quemar";
    private int turnosRestante = 3;
    public void AplicarEfecto(IPokemon objetivo)
    {
    objetivo.Estado = "Quemado"; 
    }
    public void AplicarDañoPorTurno(IPokemon objetivo)
    {
        if(turnosRestante > 0)
        {
            int daño = (int)(objetivo.VidaActual * 0.10);
            objetivo.VidaActual -= daño;
            turnosRestante--;                           // Este va disminuyendo el contador de turnos en 1
        }
    }

}
