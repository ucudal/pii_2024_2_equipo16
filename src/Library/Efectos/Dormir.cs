namespace Library;

/// <summary>
/// Implementa el tipo IEfectos, puede ser utilizado en ataques especiales.
/// </summary>
public class Dormir : AplicarDaño, IEfectos
{
    public string nombreEfecto {get; set;} = "Dormir";
    
    /// <summary>
    /// Un Pokémon puede estar dormido entre 1 y 4 turnos aleatoriamente, luego de ello se despierta y vuelve a la normalidad. 
    /// </summary>
    private int turnosRestante = 3;

    /// <summary>
    /// Avisa que el efecto aplicado en el objetivo (Pokemon enemigo es "Dormido")
    /// </summary>
    public void AplicarEfecto(IPokemon objetivo)
    {
        objetivo.Estado = "Dormido";
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