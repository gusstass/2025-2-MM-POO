public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Elo;
    }


    public string Numero { get; set; }/* por ser um número que não será usado em contas pode se colocar como string */
    //public string Bandeira {get;set;};
    public BandeiraCartao Bandeira { get; set; }
    public DateTime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }

}

public enum BandeiraCartao /* lista de opções para controlar o que o usuário vai digitar */
{
    Visa,
    Mastercard,
    Amex,
    Elo
}
