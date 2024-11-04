using System;

<<<<<<< HEAD
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
}
=======
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
>>>>>>> 35dd2a67fc1b71cf9bb7fdba096924c12968e817
