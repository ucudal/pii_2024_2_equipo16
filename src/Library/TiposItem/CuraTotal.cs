namespace Library
{
    /// <summary>
    /// Se pueden usar hasta 2, este item logra que
    /// se cure a un Pokémon de efectos de ataques especiales, dormido, paralizado, envenenado, o quemado
    /// </summary>
    public class CuraTotal:IItem
    {
        public string NombreItem {get;}

        public CuraTotal()
        {
            NombreItem = "Cura Total";
        }
        
        /// <summary>
        /// Metodo para quitar los efectos
        /// </summary>
        /// <returns></returns>
        public double QuitarEfectos()
        {
            return 2;
        }
    }
}