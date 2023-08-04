using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public static class Menu
    {
        public static void ExibirMenu()
        {        
            Console.Clear();
            Console.WriteLine("Digite a sua opção: \n");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar\n");                  
        }

        public static void RetornarMenu()
        {
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            Menu.ExibirMenu();
        }        
    }
}