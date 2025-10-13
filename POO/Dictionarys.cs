namespace POO;
using POO.Pessoa;
public class Dictionarys
{
    public Dictionarys(Dictionary<string, int> dictionary)
    {
        Alunos = dictionary;
    }
    private Dictionary<string, int> alunos = new Dictionary<string, int>();

    public Dictionary<string, int> Alunos
    {
        get => alunos;
        set => alunos = value ?? throw new ArgumentNullException(nameof(value));
    }
    
}