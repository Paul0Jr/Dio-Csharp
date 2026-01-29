namespace POO.Desafios.Desafio1;

public class Saudacao : Message
{
    public Saudacao(string name)
    {
        this.Name = name;
    }

    private readonly string name;

    public string Name { get; set; }

    public override void Resposta()
    {
        Console.WriteLine($"Bem-vindo, {Name}!");
    }
}