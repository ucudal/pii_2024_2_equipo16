namespace Library;

public class SuperPocion : IItem
{
    public string NombreItem { get; }
    private int usosRestantes;
    private const int usosMaximos = 4;

    public SuperPocion()
    {
        NombreItem = "Super Pocion";
        usosRestantes = usosMaximos; // Inicializa el contador de usos
    }

    // Método para curar
    public double Curar(double VidaActual, double VidaTotal)
    {
        if (usosRestantes > 0)
        {
            if (VidaActual < VidaTotal - 70)
            {
                usosRestantes--; // Reduce el contador de usos
                return VidaActual + 70; // Si la diferencia es mayor a 70, se curan 70 puntos
            }
            else
            {
                usosRestantes--; // Reduce el contador de usos
                return VidaTotal; // Si no, se cura hasta el máximo (VidaTotal)
            }
        }
        else
        {
            Console.WriteLine("No se pueden usar más 'Super Pocion' en esta batalla.");
            return VidaActual; // Devuelve la vida actual sin cambios
        }
    }
}