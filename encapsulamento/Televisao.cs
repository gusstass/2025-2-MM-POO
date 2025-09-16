public class Televisao
{
    private const int VOL_MAX=100;
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho{get;} //removendo o set; para que seja lido porem não escrito por um código externo.
    public int Resolucao{get; set;}
    public int Volume{get; private set;} //privando o set para nao ter alterações externas
    public int Canal{get; set;}
    public bool Estado{get; set;}

    public void AumentarVolume()
    {
        if(Volume < VOL_MAX)
        Volume = Volume+1; //Volume++ 
        else
        Console.WriteLine("TV está no máximo");
    }
}