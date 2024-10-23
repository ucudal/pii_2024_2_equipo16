namespace Library;

public class Dormir : IEfectos
{
    public string nombreEfecto {get; set;} = "Dormir";
    private int turnosRestante = 3;

    public void AplicarEfecto(IPokemon objetivo)
    {
        objetivo.Estado = "Envenenado";
    }

    public void AplicarDañoPorTurno(IPokemon objetivo)
    {
        if (turnosRestante > 0)
        {
            int daño = (int)(objetivo.VidaActual * 0.05);

            objetivo.VidaActual -= daño;
            
            turnosRestante--;
        }
    }

}

/* 
Ejemplo de uso:
Dormir efectoDormir = new Dormir();
efecto.Dormir.AplicarEfecto(pokemon);

if (!efectoDormir.PuedeAtacar())
{
    Consolo.Writeline("El pokemon no puede atacar, se encuentra dormido")
}

{
else
}
{
    Console.Writeline("El pokemon está despierto y puede atacar")
}
*/