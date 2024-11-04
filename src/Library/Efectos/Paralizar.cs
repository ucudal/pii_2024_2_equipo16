using System;

<<<<<<< HEAD
namespace Library
{
    // Clase que aplica el efecto Paralizar.
    public class Paralizar : IEfectos
    {
        public string nombreEfecto { get; set; } = "Paralizar";

        // Aplicar el efecto de parálisis al Pokémon.
        public void AplicarEfecto(IPokemon objetivo)
        {
            objetivo.Estado = "Paralizado";
        }

        // Determina aleatoriamente si el Pokémon puede atacar.
        public bool PuedeAtacar()
        {
            Random random = new Random();
            return random.Next(0, 2) == 1; // Retorna true (puede atacar) o false (no puede atacar).
        }
    }
}
=======
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
>>>>>>> 35dd2a67fc1b71cf9bb7fdba096924c12968e817
