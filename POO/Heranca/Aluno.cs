namespace POO.Heranca;
using POO.Pessoa;

public class Aluno : Pessoa
{
    //Herdando a classe Pai + Atributos do construtor
    public Aluno(string name, string sobrenome) : base(name, sobrenome)
    {
        this.Nome = name;
        this.Sobrenome = sobrenome;
    }
}