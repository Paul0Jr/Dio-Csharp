namespace POO.Curso;
using POO.Pessoa;

public class Curso {
    public Curso(string nome, List<Pessoa> alunos)
    {
        Nome = nome;
        Alunos = alunos;
    }
    private string nome;

    public string Nome
    {
        get => nome;
        set{
            if (value == "")
            {
                throw new ArgumentException("O nome do curso não pode ser vazio!");
            }
            nome = value;
        }
    }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAlunos(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }

    public int QtdAlunos()
    {
        int qtd = Alunos.Count();
        return qtd;
    }

    public bool RemoverAluno(Pessoa aluno)
    {
       return Alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
        foreach (Pessoa aluno in Alunos)
        {
            Console.WriteLine(aluno.NomeCompleto);
        }
    }
}