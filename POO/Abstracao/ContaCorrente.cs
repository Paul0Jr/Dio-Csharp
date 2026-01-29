namespace POO.Abstracao;

public sealed class ContaCorrente : Conta
{
    public override void Creditar(decimal valor)
    {
        saldo += valor;
    }
}