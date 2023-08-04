namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {  
            Cabecalho.ExibirAdicionar();
            string placa = Console.ReadLine();            
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso!\n");
            Menu.RetornarMenu();
        }

        public void RemoverVeiculo()
        {
            Cabecalho.ExibirRemover();
            string placa = Console.ReadLine();
     
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 
       
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

            Menu.RetornarMenu();
        }

        public void ListarVeiculos()
        {
            Cabecalho.ExibirListar();
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n");            
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine("● " + veiculo);                    
                }                 
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            Menu.RetornarMenu();
        }
    }
}