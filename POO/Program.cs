using POO.Pessoa;
using POO.Curso;
using POO.Vendas;
using Newtonsoft.Json;
using POO.Abstracao;
using POO.Desafios;
using POO.Desafios.Desafio1;

string message = Console.ReadLine();
Mensagem saud = new Mensagem(message);
saud.Resposta();