/*
 Sistema de Estacionamento que receba:
 * O preço inicial do estacionamento
 * O preço pago por hora
 * Um menu interativo que possua as seguintes opções: Cadastrar Veículo, Remover Veículo, Listar, Encerrar.
 Obs: Para cada nova interação, passa-se 1h.
 */
 
List<String> parkinglot = new List<string>();
List<int> vehiclehour = new List<int>();
int hour, op, index;
float price = 0, pricehour = 0;
string plate;

Console.Write("Digite o preço inicial do estacionamento: ");
price = float.Parse(Console.ReadLine());
Console.Write("Digite o preço pago por hora: ");
pricehour = float.Parse(Console.ReadLine());
 
Console.WriteLine("\n======== BEM-VINDO AO SISTEMA DO ESTACIONAMENTO ========");
while (true) {
    for (int i = 0; i < vehiclehour.Count; i++)
    {
        vehiclehour[i]++;
    }
    Console.WriteLine("\nEscolha uma opção:" +
                      "\n[1] Cadastrar Veículo" +
                      "\n[2] Remover Veículo" +
                      "\n[3] Listar veículos" +
                      "\n[4] Encerrar" +
                      "\nSua opção:");
    op = int.Parse(Console.ReadLine());
    if (op == 4)
    {
        Console.WriteLine("\nObrigado por usar nosso sistema!");
        break;
    }


    switch (op)
    {
        case 1:
            Console.Write("\nDigite a placa do veículo que deseja adicionar: ");
            plate = Console.ReadLine();
            if (parkinglot.Contains(plate))
            {
                Console.WriteLine("\nEste carro já está estacionado!");
                break;
            }

            parkinglot.Add(plate);
            vehiclehour.Add(0);
            break;
        
        case 2:
            Console.Write("\nDigite a placa do veículo que deseja remover: ");
            plate = Console.ReadLine();
            index = parkinglot.IndexOf(plate);
            if (index == -1)
            {
                Console.WriteLine("\nEste carro não está estacionado!");
                break;
            }
            Console.WriteLine($"\nEste carro ficou estacionado por {vehiclehour[index]} horas");
            Console.WriteLine($"O valor a ser pago pelo veículo é de R${price + (pricehour * vehiclehour[index])}");
            parkinglot.RemoveAt(index);
            vehiclehour.Remove(index);
            break;

        case 3:
            Console.WriteLine("\n==== Veículos Estacionados ====");
            if (parkinglot.Count == 0)
            {
                Console.WriteLine("O estacionamento está vazio.");
            }
            else
            {
                for (int i = 0; i < parkinglot.Count; i++)
                {
                    Console.WriteLine(vehiclehour[i] == 1 ? $"Placa: {parkinglot[i]} - Tempo: {vehiclehour[i]} hora" : 
                        $"Placa: {parkinglot[i]} - Tempo: {vehiclehour[i]} horas");
                }
            }
            break;
        default: Console.WriteLine("Opção Inválida!"); return;
    }
}