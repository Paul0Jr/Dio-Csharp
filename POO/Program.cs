using POO.Pessoa;
using POO.Curso;
using POO.Vendas;
using Newtonsoft.Json;

Vendas venda = new Vendas(12, "Caneca", 12.00M);
string serialize = JsonConvert.SerializeObject(venda, Formatting.Indented);

//Serialização
File.WriteAllText("C#/vendas.json", serialize);
Console.WriteLine(serialize);

//Descerialização
File.ReadAllText("Path");

/*DateTime data = new DateTime();
Pessoa pessoa = new Pessoa("Paulo", "Sérgio");
Pessoa pessoa2 = new Pessoa("Samuel", "Vieira");
Curso curso = new Curso("Programação", new List<Pessoa>());

curso.AdicionarAlunos(pessoa);
curso.AdicionarAlunos(pessoa2);
curso.ListarAlunos();

data = DateTime.Now;

Console.WriteLine(data.ToString("dd/M/yyyy HH:mm")); */