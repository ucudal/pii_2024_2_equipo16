namespace Library
{
    /// <summary>
    /// Este tipo de Item logra que se reviva a un Pokemon con el 50% de su HP total.
    /// </summary>
    public class Revivir : IItem
    {
        public string NombreItem { get; }

        public Revivir()
        {
            NombreItem = "Revivir";
        }

        /// <summary>
        /// Metodo para quitar los efectos
        /// </summary>
        /// <param name="VidaActual"></param>
        /// <param name="VidaTotal"></param>
        /// <returns></returns>
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