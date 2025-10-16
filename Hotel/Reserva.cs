namespace Hotel.Reserva;
using Hotel.Pessoa;
using Hotel.Suite;

public class Reserva
{
    public Reserva(int dias)
    {
        DiasReservados = dias;
    }
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospede(List<Pessoa> hospedes)
    {
        if (hospedes.Count > Suite.Capacidade)
        {
            throw new ArgumentException("\nO valor de hóspedes excede a capacidade da suíte!");
        }
        Hospedes = hospedes;
    }

   public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQtdHospedes()
    {
        return Hospedes.Count;
    }
    
    public decimal CalcularValorDiaria()
    {
        decimal discount = 0, total = 0;
        if (DiasReservados >= 10)
        {
            discount = Suite.ValorDiaria - (Suite.ValorDiaria * 0.10M);
            total = discount * DiasReservados;
        }
        else
        {
            total = DiasReservados * Suite.ValorDiaria;
        }
        return total;
    }
    
}