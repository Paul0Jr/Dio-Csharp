namespace POO.Vendas;

public class Vendas
{
    public Vendas(int id, string nome, decimal preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
    }
    
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}