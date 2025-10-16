namespace Hotel.Pessoa;

public class Pessoa
{
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    private string nome;
    public string Nome { get=>nome; set{
            if (value == "")
            {
                throw new ArgumentException("\nO nome do hóspede não pode ser vazio!");
            }
            nome = value;
        }
    }

    private string sobrenome;
    public string Sobrenome { get=>sobrenome; set{
            if (value == "")
            {
                throw new ArgumentException("\nO sobrenome do hóspede não pode ser vazio!");
            }
            sobrenome = value;
        }
    }
}