namespace EntregaUno;

// Esta interfaz define los atributos y métodos de un pókemon
public interface IPokemon
{
    public string Nombre { get; set; }                  //Nombre del pókemon
    public ITipo TipoPokemon { get; set; }              //Tipo del pókemon
    public double Vida { get; set; }                    //Vida del pókemon
    public double Ataque { get; set; }                  //Valor de ataque del pókemon
    public double Defensa { get; set; }                 //Valor de defensa del pókemon
    public double AtaqueEspecial { get; set; }          //Valor de ataque especial del pókemon
    public double DefensaEspecial { get; set; }         //Valor de defensa del pókemon
    public void UsarAtaque(IPokemon enemigo);           //Método para realizar un ataque 
    public void UsarAtaqueEspecial(IPokemon enemigo);   //Método para realizar un ataque especial
    public void RecibirDaño(IPokemon enemigo);          //Método para recibir daño del pókemon enemigo
    public double MostrarVida();                        //Método para mostrar la vida actual del pókemon
}