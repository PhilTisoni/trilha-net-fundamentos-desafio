using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public static class Cabecalho
    {
        public static void ExibirAbertura()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                               "          DIO PARKING\n" +
                               "===============================\n");

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");
        }

        public static void ExibirAdicionar()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                               "            ADICIONAR\n" +
                               "===============================\n");  

            Console.Write("Digite a placa do veículo para estacionar: ");
        }   

        public static void ExibirRemover()
        {
           Console.Clear();
           Console.WriteLine("===============================\n" +
                             "            REMOVER\n" +
                             "===============================\n");  

           Console.Write("Digite a placa do veículo para remover: ");
        }   

        public static void ExibirListar()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                              "            LISTAR\n" +
                              "===============================\n");  
        }          
    }
}