namespace Library;

public interface IEfectos
{
    public string nombreEfecto {get; set;}  // Va a poner el nombre del efecto, ya sea dormir, paralizar, Envenenar, Quemar
    void AplicarEfecto(IPokemon objetivo); 
}   