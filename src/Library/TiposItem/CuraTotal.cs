namespace Library;
{
    public class CuraTotal:IItem
    {
        public string NombreItem {get;}

        public CuraTotal()
        {
            NombreItem = "Cura Total";
        }
        
        // Metodo para quitar los efectos
        public double QuitarEfectos()
    }
}