using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();
            ExibirOpcoesMenu();
            

        }

        public static void ExibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************");
            Console.WriteLine("victor: ");
            Console.WriteLine("\n**********************");
            Console.WriteLine(@"
            ███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
            █░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░███░░░░░░░░░░░░░░░░███░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░██████░░░░░░██░░░░░░█░░░░░░░░░░░░░░█░░░░░░██░░░░░░█████████████████░░░░░░█
            █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀░░██████░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░███████████████░░░░▄▀░░█
            █░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░▄▀░░███░░▄▀░░░░░░░░▄▀░░███░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░▄▀░░██████░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░████░░░░░░███░░░░▄▀░░░░█
            █░░▄▀░░█████████░░▄▀░░████░░▄▀░░███░░▄▀░░████░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░████░░▄▀░░██████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░████░░▄▀░░█░░░░▄▀░░░░███
            █░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░▄▀░░███░░▄▀░░░░░░░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░▄▀░░██████░░▄▀░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░▄▀░░████░░░░░░█░░▄▀░░░░█████
            █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀░░██████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░███████████░░▄▀░░███████
            █░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░░░███░░▄▀░░░░░░▄▀░░░░███░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░▄▀░░░░██████░░░░░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█░░░░░░░░░░▄▀░░████░░░░░░█░░▄▀░░░░█████
            █░░▄▀░░█████████░░▄▀░░██░░▄▀░░█████░░▄▀░░██░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░████████████████░░▄▀░░█░░▄▀░░██░░▄▀░░█████████░░▄▀░░████░░▄▀░░█░░░░▄▀░░░░███
            █░░▄▀░░░░░░░░░░█░░▄▀░░██░░▄▀░░░░░░█░░▄▀░░██░░▄▀░░░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░░░░░████████████░░▄▀░░█░░▄▀░░░░░░▄▀░░█████████░░▄▀░░████░░░░░░███░░░░▄▀░░░░█
            █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀▄▀▄▀░░████████████░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████████░░▄▀░░███████████████░░░░▄▀░░█
            █░░░░░░░░░░░░░░█░░░░░░██░░░░░░░░░░█░░░░░░██░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██░░░░░░░░░░████████████░░░░░░█░░░░░░░░░░░░░░█████████░░░░░░█████████████████░░░░░░█
            ███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");

            Console.ResetColor();
        }





        public static void ExibirOpcoesMenu()
        {

          
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n digite 1 para registrar informacoes");
            Console.WriteLine("\n digite 2 para listar informacoes");
            Console.WriteLine("\n digite 3 para apagar informacoes");
            Console.WriteLine("\n digite -1 para sair \n");
            Console.WriteLine("\n digite a opcao escolhida");
           
            string opcaoEscolhida = Console.ReadLine();

            int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
           
            switch (opcaoEscolhidaNumero)
            {
                case 1:
                    CadInfo();
                    
                    break;

                case 2:
                    Console.WriteLine("\nVoce escolheu a opção 2");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;

                case 3:
                    Console.WriteLine("\nVoce escolheu a opção 3");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine("\n saindo...");
                    Thread.Sleep(3000);
                    break;


                    default:
                    Console.WriteLine("\n voce digitou uma opcao invalida");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;


            }


        }


        private static void CadInfo()
        {       
            Console.Clear();
            Console.WriteLine("\nVoce escolheu a opção 1");
            Console.WriteLine("digite seu lindo nome");
            string nomeDoUsuario = Console.ReadLine();
            Console.WriteLine($"nome cadastro com sucesso!!! {nomeDoUsuario}");
            Thread.Sleep(6000);
            ExibirCabecalho();
            ExibirOpcoesMenu();

        }

    }
}

/*
           int opcaoEscolhidanumero =  int.Parse(opcaoEscolhida);
           if (opcaoEscolhidanumero == 1)
           {
               Console.WriteLine("\nVoce escolheu a opção 1");
           }
            if (opcaoEscolhidanumero == 2)
           {
               Console.WriteLine("\nVoce escolheu a opção 2");
           }
            if (opcaoEscolhidanumero == 3)
           {
               Console.WriteLine("\nVoce escolheu a opção 3");
           }
            if (opcaoEscolhidanumero == -1)
           {
               Console.WriteLine("\nVoce escolheu a opção -1");

           }*/