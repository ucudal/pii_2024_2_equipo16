namespace Library
{
    public class Revivir : IItem
    {
        public string NombreItem { get; }
        private int usosRestantes;
        private const int usosMaximos = 1;

        public Revivir()
        {
            NombreItem = "Revivir";
            usosRestantes = usosMaximos; 
        }

        // Método para revivir
        public double RevivirPokemon(double VidaActual, double VidaTotal)
        {
            if (usosRestantes > 0)
            {
                if (VidaActual == 0) // Compara si la vida es 0
                {
                    usosRestantes--; 
                    return VidaActual = VidaTotal * 0.5;
                }
                else
                {
                    Console.WriteLine("Solo se puede revivir cuando el pokemon está muerto");
                    return VidaActual; // Devuelve la vida actual sin cambios
                }
            }
            else
            {
                Console.WriteLine("No se pueden usar más 'Revivir' en esta batalla.");
                return VidaActual;
            }
        }
    }
}