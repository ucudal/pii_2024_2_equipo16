namespace EntregaUno;

public interface IPokemon
{
    string Nombre { get; set; }
    ITipo TipoPokemon { get; set; }
    double Vida { get; set; }
    double Ataque { get; set; }
    double Defensa { get; set; }
    double AtaqueEspecial { get; set; }
    double DefensaEspecial { get; set; }
    void UsarAtaque(IPokemon enemigo);
    void UsarAtaqueEspecial(IPokemon enemigo);
    void RecibirDaño(IPokemon enemigo);
    double MostrarVida();
}