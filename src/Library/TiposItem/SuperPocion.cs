namespace Library;

/// <summary>
/// Con este tipo de Item, se pueden usar hasta 4 y cada una recupera 70 puntos de HP.
/// </summary>
public class SuperPocion: IItem
{
    public string NombreItem { get; }

    public SuperPocion()
    {
        NombreItem = "Super Pocion";
    }

    /// <summary>
    /// Método para curar, recibe la vida actual y la total del pokemón e intenta reestablecerla.
    /// </summary>
    /// <param name="VidaActual"></param>
    /// <param name="VidaTotal"></param>
    /// <returns></returns>
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