namespace EntregaUno.TiposPokemon;

public class Tierra: ITipo
{
    public string NombreTipo { get; set; } = "Tierra";
     public double Ponderador(ITipo tipoOponente) //Recibe como parámetro otros tipos de pokemones
    {
        if (tipoOponente.NombreTipo == "Electrico" || tipoOponente.NombreTipo == "Fuego" )
        {
            return 2.0; //Es fuerte ante al Fuego y Electrico
        }
        else if (tipoOponente.NombreTipo == "Agua" || tipoOponente.NombreTipo=="Planta" || tipoOponente.NombreTipo=="Hielo")
        {
            return 0.5; //Debil ante Agua, Planta y Hielo

        }
        return 1.0; //Si es enfrentado frente a otro tipo, el ponderador será neutro.
    }
}