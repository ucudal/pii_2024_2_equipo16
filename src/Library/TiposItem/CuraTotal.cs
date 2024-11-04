namespace Library
{
    public class CuraTotal : IItem
    {
        public string NombreItem { get; }
        private int usosRestantes;
        private const int usosMaximos = 2;

        public CuraTotal()
        {
            NombreItem = "Cura Total";
            usosRestantes = usosMaximos;
        }

        // Método para quitar los efectos
        public void QuitarEfectos(IPokemon objetivo)
        {
            if (usosRestantes > 0)
            {
                if (objetivo.EfectoActivo != null)
                {
                    objetivo.EfectoActivo = null;
                    objetivo.Estado = "Normal";
                    Console.WriteLine($"{objetivo.Nombre} ya no está bajo ningún efecto");
                    usosRestantes--;
                }
                else
                {
                    Console.WriteLine($"{objetivo.Nombre} no tiene efectos activos.");
                }
            }
            else
            {
                Console.WriteLine("No se pueden usar más 'Cura Total' en esta batalla.");
            }
        }
    }
}