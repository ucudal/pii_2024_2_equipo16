namespace EntregaUno;

// Esta interfaz define el tipo de pókemon y determina la potencia de los ataques según el tipo de pókemon que será atacado
public interface ITipo
{
    public string NombreTipo { get; set; }         //Nombre del tipo de pókemon
    public double Ponderador { get; set; }         //Define la efectividad de los ataques dependiendo del tipo
}