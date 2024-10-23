namespace Library;

public class Paralizar : IEfectos
{
    public string nombreEfecto {get; set;} = "Paralizar";

    public void AplicarEfecto (IPokemon objetivo)
    {
        objetivo.Estado = "paralizado";
    }

    public bool PuedeAtacar()
    {
        Random random = new Random();
        return random.Next(0, 2) == 1;
    }
}