namespace Library;

public class SuperPocion: IItem
{
    public string NombreItem { get; }

    public SuperPocion()
    {
        NombreItem = "Super Pocion";
    }

    // Método para curar
    public double Curar(double VidaActual, double VidaTotal)
    {
        if (VidaActual < VidaTotal - 70)
        {
            return VidaActual + 70; // Si la diferencia es mayor a 70, se curan 70 puntos
        }
        else
        {
            return VidaTotal; // Si no, se cura hasta el máximo (VidaTotal)
        }
    }
}