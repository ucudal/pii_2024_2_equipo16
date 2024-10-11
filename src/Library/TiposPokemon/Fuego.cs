namespace Library;

public class Fuego: ITipo
{
    public string NombreTipo { get;} 

    public Fuego()
    {
        NombreTipo = "Fuego";
    }

    //Mediante este método, se analiza frente a qué tipos es debil el fuego
    // y frente a cuales es fuerte.
    // Si es fuerte, el ponderador será 2, significando que el daño que realizará será multiplicado por ese número.
    // De lo conrtario, el dañó será reducido a la mitad por el ponderador.
    public double Ponderador(ITipo tipoOponente) //Recibe como parámetro otros tipos de pokemones
    {
        if (tipoOponente.NombreTipo == "Acero" || tipoOponente.NombreTipo == "Hielo" || tipoOponente.NombreTipo== "Planta")
        {
            return 2.0; //El fuego es fuerte ante el acero, hielo y planta
        }
        else if (tipoOponente.NombreTipo == "Tierra" || tipoOponente.NombreTipo=="Agua")
        {
            return 0.5; //Fuego es debil ante la Tierra y Agua

        }
        return 1.0; //Si el fuego es enfrentado frente a otro tipo, el ponderador será neutro.
    }
}