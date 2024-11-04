using System;

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
