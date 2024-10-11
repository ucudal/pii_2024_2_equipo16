namespace Library;

public class Agua: ITipo
{
    public string NombreTipo { get; }

    public Agua()
    {
        NombreTipo = "Agua";
    }
    public double Ponderador(ITipo tipoOponente) //Recibe como parámetro otros tipos de pokemones
    {
        if (tipoOponente.NombreTipo == "Fuego" || tipoOponente.NombreTipo == "Tierra")
        {
            return 2.0; //Es fuerte ante el Fuego y tierra
        }
        else if (tipoOponente.NombreTipo == "Planta" || tipoOponente.NombreTipo=="Electrico")
        {
            return 0.5; // Es debil ante Planta y electrico

        }
        return 1.0; //Si el fuego es enfrentado frente a otro tipo, el ponderador será neutro.
    }
}