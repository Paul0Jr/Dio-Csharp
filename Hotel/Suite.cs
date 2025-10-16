namespace Hotel.Suite;

public class Suite
{
    public Suite(string tipo, int capacidade, decimal valor)
    {
        TipoSuite = tipo;
        Capacidade = capacidade;
        ValorDiaria = valor;
    }
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }
}