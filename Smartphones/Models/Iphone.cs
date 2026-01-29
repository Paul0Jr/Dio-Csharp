namespace Smartphones.Models;

public class Iphone : Smartphone
{
    public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory){}
    
    public override void InstallApp(string nameApp)
    {
        Console.WriteLine($"Instalando {nameApp} no seu dispositivo...");
    }
}