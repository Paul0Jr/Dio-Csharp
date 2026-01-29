using System.Runtime.CompilerServices;

namespace POO.Desafios.Desafio1;

public class Mensagem : Message
{
    public Mensagem(string saudacao)
    {
        this.Saudacao = saudacao;
    }
    
    private string Saudacao { get; }

    public override void Resposta()
    {
        Console.WriteLine($"BOT: Obrigado pela mensagem: {Saudacao}");
    }
}