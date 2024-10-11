namespace EntregaUno;

// Esta interfaz define los atributos y métodos de un pokémon
public interface IPokemon
{
    public string Nombre { get; set; }                  //Nombre del pokémon
    public ITipo TipoPokemon { get; set; }              //Tipo del pokémon
    public double Vida { get; set; }                    //Vida del pokémon
    public double Ataque { get; set; }                  //Valor de ataque del pokémon
    public double Defensa { get; set; }                 //Valor de defensa del pokémon
    public double AtaqueEspecial { get; set; }          //Valor de ataque especial del pokémon
    public double DefensaEspecial { get; set; }         //Valor de defensa del pokémon
    public void UsarAtaque(IPokemon enemigo);           //Método para realizar un ataque 
    public void UsarAtaqueEspecial(IPokemon enemigo);   //Método para realizar un ataque especial
    public void RecibirDaño(IPokemon enemigo);          //Método para recibir daño del pokémon enemigo
    public double MostrarVida();                        //Método para mostrar la vida actual del pokémon
}