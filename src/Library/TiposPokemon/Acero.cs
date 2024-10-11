namespace EntregaUno.TiposPokemon;

public class Acero: ITipo
{
    public string NombreTipo { get; set; } = "Acero";
    public double Ponderador(ITipo tipoOponente) //Recibe como parámetro otros tipos de pokemones
    {
        if (tipoOponente.NombreTipo == "Hielo")
        {
            return 2.0; //El acero es fuerte ante el hielo.
        }
        else if (tipoOponente.NombreTipo == "Fuego")
       {
            return 0.5; //Es debil frente al fuego

        }
        return 1.0; //Si es enfrentado frente a otro tipo, el ponderador será neutro.
    }
}