namespace POO.Abstracao;

public abstract class Conta
{
    
    protected decimal saldo;

    public abstract void Creditar(decimal valor);
    
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo de: R${saldo}");
    }
}