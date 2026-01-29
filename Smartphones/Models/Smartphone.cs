namespace Smartphones.Models;

public abstract class Smartphone
{
    public Smartphone(string number, string model, string imei, int memory)
    {
        this.Number = number;
        this.Model = model;
        this.IMEI = imei;
        this.Memory = memory;
    }
    
    protected string Number { get; set;}
    protected string Model { get; set;}
    protected string IMEI { get; set;}
    protected int Memory { get; set;}

    public void TurnOn()
    {
        Console.WriteLine($"Ligando o seu {Model}");
    }

    public void CallReceive()
    {
        // Implementar número aleatório
        Console.WriteLine("\"Recebendo ligação de ...");
    }

    public abstract void InstallApp(string name);
}