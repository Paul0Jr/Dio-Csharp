using POO.Pessoa;
using POO.Curso;

DateTime data = new DateTime();
Pessoa pessoa = new Pessoa("Paulo", "Sérgio");
Pessoa pessoa2 = new Pessoa("Samuel", "Vieira");
Curso curso = new Curso("Programação", new List<Pessoa>());

curso.AdicionarAlunos(pessoa);
curso.AdicionarAlunos(pessoa2);
curso.ListarAlunos();

data = DateTime.Now;

Console.WriteLine(data.ToString("dd/M/yyyy HH:mm"));