using System;
using ProductList;
using Microsoft.Data.SqlClient;

namespace Project_Salltar
{
    class Program
    {
        static void Main(string[] args)
        {
            string Resp;

            do
            {

                Console.WriteLine("------------------------------------");
                Console.WriteLine("Selecione o que deseja apresentar:");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1- Lista de produto");
                Console.WriteLine("2- Adicionar produto");
                Console.WriteLine("3- Editar produto");
                Console.WriteLine("4- Remover produto");
                Console.WriteLine("5- Fechar");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Resp = Console.ReadLine();
                
                switch (Resp)
                {
                    case "1":
                        Console.Clear();
                        Produto.ListerPdt();

                        break;
                    case "2":
                        Console.Clear();
                        Produto.InsertPdt();

                        break;
                    case "3":
                        Console.Clear();
                        Produto.ChangePdt();

                        break;
                    case "4":
                        Console.Clear();
                        Produto.RemovePdt();

                        break;
                    case "5":
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (Resp != "5");
        }
    }
}
