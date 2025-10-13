namespace POO.Exceptions;

public class Arquivo
{
    
    public void Leitura()
    {
        try
        {
            string[] file = File.ReadAllLines("Exceptions/Texto.txt");
            foreach (string linha in file)
            {
                Console.WriteLine(linha);
            }
        }
        catch (Exception ex){Console.WriteLine($"Ocorreu um erro: {ex.Message}");}
    }
}