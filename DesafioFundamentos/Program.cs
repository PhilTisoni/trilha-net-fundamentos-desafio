using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;
Cabecalho.ExibirAbertura();

decimal precoInicial = 0;
decimal precoPorHora = 0;
string opcao = string.Empty;

Console.Write("Digite o preço inicial: R$ ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço por hora: R$ ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new(precoInicial, precoPorHora);

bool exibirMenu = true;

    while (exibirMenu)
    {
        Menu.ExibirMenu();
        switch (Console.ReadLine())
        {
            case "1":
                es.AdicionarVeiculo();
                break;

            case "2":
                es.RemoverVeiculo();
                break;

            case "3":
                es.ListarVeiculos();
                break;

            case "4":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

Console.Clear();
Console.WriteLine("O programa se encerrou\n\n");
Environment.Exit(0);