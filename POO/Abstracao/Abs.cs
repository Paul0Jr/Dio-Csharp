namespace POO.Abstracao.Abs;

public class Abs
{
    public Abs(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos!");
    }
}