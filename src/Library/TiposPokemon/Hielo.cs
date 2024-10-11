namespace Library;

public class Hielo: ITipo
{
    public string NombreTipo { get; }
    
    public Hielo()
    {
        NombreTipo = "Hielo";
    } 
    public double Ponderador(ITipo tipoOponente) //Recibe como parámetro otros tipos de pokemones
    {
        if (tipoOponente.NombreTipo == "Tierra" || tipoOponente.NombreTipo == "Planta" )
        {
            return 2.0; //Es fuerte ante la Tierra y la Planta
        }
        else if (tipoOponente.NombreTipo == "Acero" || tipoOponente.NombreTipo=="Fuego")
        {
            return 0.5; //Debil ante Acero y Fuego

        }
        return 1.0; //Si es enfrentado frente a otro tipo, el ponderador será neutro.
    }
}