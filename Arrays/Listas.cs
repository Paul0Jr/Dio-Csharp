namespace Arrays;

public class Listas

{
    private List<string> nomes = new List<string>();
    public int cont { get; set; }
    public void Lista()
    {
        cont = 1;
        string nome;
        while (true)
        {
            Console.WriteLine($"Digite o {cont}° nome:");
            nome = Console.ReadLine();
            if(nome=="0")
            {
                nomes.Remove(nomes[0]);break;}
            nomes.Add(nome);
            cont++;
        }

        foreach (string i in nomes)
        {
            if (!(i == "0"))
            {
            Console.WriteLine(i);
            }
        }
    }
}