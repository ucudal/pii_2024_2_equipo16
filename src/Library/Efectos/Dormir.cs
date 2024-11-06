using System;

<<<<<<< HEAD
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

 
=======
namespace Library
{
    // Clase que aplica el efecto Dormir.
    public class Dormir : IEfectos
    {
        public string nombreEfecto { get; set; } = "Dormir";
        private int turnosRestante; // Número de turnos que el Pokémon permanecerá dormido.

        // Aplica el efecto de dormir al Pokémon objetivo, estableciendo los turnos de sueño.
        public void AplicarEfecto(IPokemon objetivo)
        {
            objetivo.Estado = "Dormido";
            
            // Genera un número aleatorio de turnos entre 1 y 4.
            Random random = new Random();
            turnosRestante = random.Next(1, 5);
        }

        // Verifica si el Pokémon aún está dormido y ajusta el estado en consecuencia.
        public void VerificarEstado(IPokemon objetivo)
        {
            if (turnosRestante > 0)
            {
                turnosRestante--; // Reducimos el número de turnos restantes.
            }
            else
            {
                objetivo.Estado = "Normal"; // El Pokémon despierta y vuelve a la normalidad.
            }
        }

        // Método que indica si el Pokémon puede atacar.
        public bool PuedeAtacar()
        {
            return turnosRestante <= 0;
        }
    }
>>>>>>> main
}
