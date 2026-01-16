namespace BoBase.Bo;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Imagem { get; set; }
    public int Quantidade { get; set; }
    public bool Status { get; set; }

    public Produto()
    {
        Nome = string.Empty;
        Preco = 0;
        Imagem = string.Empty;
        Quantidade = 0;
        Status = false;
    }
}
