using Hotel.Suite;
using Hotel.Pessoa;
using Hotel.Reserva;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite("Premium", 2, 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva( 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospede(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQtdHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");