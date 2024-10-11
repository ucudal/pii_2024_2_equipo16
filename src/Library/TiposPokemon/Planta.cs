namespace EntregaUno.TiposPokemon;

public class Planta: ITipo
{
    public string NombreTipo { get; set; } = "Planta";
    public double Ponderador(ITipo tipoOponente) //Recibe como parámetro otros tipos de pokemones
    {
        if (tipoOponente.NombreTipo == "Tierra" || tipoOponente.NombreTipo == "Agua" )
        {
            return 2.0; //Es fuerte ante la Tierra y el Agua
        }
        else if (tipoOponente.NombreTipo == "Hielo" || tipoOponente.NombreTipo=="Fuego")
        {
            return 0.5; //Debil ante Hielo y Fuego

        }
        return 1.0; //Si es enfrentado frente a otro tipo, el ponderador será neutro.
    }
}