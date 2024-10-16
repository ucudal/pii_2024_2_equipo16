namespace Library;

public class Quemar : IEfectos
{
    public string nombreEfecto {get; set;} = "Quemar";
    private int turnosRestante = 3;
    public void AplicarEfecto(IPokemon objetivo)
    {
    objetivo.Estado = "Envenenado"; 
    }
    public void AplicarDañoPorTurno(IPokemon objetivo)
    {
        if(turnosRestante > 0)
        {
            objetivo.VidaActual -= 5;
            turnosRestante--;
        }
    }
}
