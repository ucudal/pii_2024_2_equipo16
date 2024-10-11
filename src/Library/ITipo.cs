namespace Library;

// Esta interfaz define el tipo de pokémon y determina la potencia de los ataques según el tipo de pókemon que será atacado
public interface ITipo
{
    public string NombreTipo { get;  }         //Nombre del tipo de pokémon
    
    
    //Mediante este método, se analiza frente a qué tipos es debil el fuego
    // y frente a cuales es fuerte.
    // Si es fuerte, el ponderador será 2, significando que el daño que realizará será multiplicado por ese número.
    // De lo conrtario, el dañó será reducido a la mitad por el ponderador.
    public double Ponderador(ITipo tipoOponente);         //Define la efectividad de los ataques dependiendo del tipo
}