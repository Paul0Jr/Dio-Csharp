using POO.Pessoa;
using POO.Curso;
using POO.Vendas;
using Newtonsoft.Json;
using POO.Abstracao;

ContaCorrente corrente = new ContaCorrente();

corrente.Creditar(500);
corrente.ExibirSaldo();