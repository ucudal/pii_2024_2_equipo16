namespace Library
{
    public class Revivir : IItem
    {
        public string NombreItem { get; }

        public Revivir()
        {
            NombreItem = "Revivir";
        }

        // Metodo para revivir
        public double RevivirPokemon(double VidaActual, double VidaTotal)
        {
            if (VidaActual == 0) // Compara si la vida es 0
            {
                return VidaActual = VidaTotal * 0.5; 
            }
            else
            {
                Console.WriteLine("Solo se puede revivir cuando la vida es 0");
                return VidaActual; // Devuelve la vida actual sin cambios
            }
        }
    }
}