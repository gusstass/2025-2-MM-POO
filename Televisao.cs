public class Televisao
{
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho{get;} //removendo o set; para que seja lido porem não escrito por um código externo.
    public int Resolucao{get; set;}
    public int Volume{get; set;} //
    public int Canal{get; set;}
    public bool Estado{get; set;}

    public void AumentarVolume()
    {
        Volume = Volume+1; //Volume++ 
    }
}