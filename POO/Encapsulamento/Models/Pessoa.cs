namespace POO.Pessoa ;

public class Pessoa {
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;

    }
    private string nome;
    private string sobrenome;
    private int idade;
    public string Nome {
        get => nome;
        set{
            if (value == "") {
                throw new ArgumentException("O nome não pode ser vazio!");
            }
            nome = value;
        }
    }

    public string Sobrenome {
        get => sobrenome;
        set{
            if (value == "") {
                throw new ArgumentException("O sobrenome não pode ser vazio!");
            }
            sobrenome = value;
        }
    }
    public string NomeCompleto { get => $"{Nome} {Sobrenome}";}
    
    public int Idade {
        get => idade;
        set {
            if (value <= 0) {
                throw new ArgumentException("A idade não pode ser um valor negativo!");
            }
            idade = value;
        }
    }

    public void Apresentacao() {
        Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos!");
    }
    
}