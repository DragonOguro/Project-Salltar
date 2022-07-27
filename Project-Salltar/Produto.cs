using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Project_Salltar;

namespace ProductList
{
    class Produto
    {
        private string NnamePdt;
        private int CcodigoPdt;
        private double PprecoPdt;
        private int QqntPdt;

        public string namePdt { get { return NnamePdt; } set { NnamePdt = value; } }
        public int codePdt { get { return CcodigoPdt; } set { CcodigoPdt = value; } }
        public double precoPdt { get { return PprecoPdt; } set { PprecoPdt = value; } }
        public int qntPdt { get { return QqntPdt; } set { QqntPdt = value; } }

        public static void InsertPdt()
        {
            Produto NewPdt = new Produto();
            Console.WriteLine("Adicionar Produto --------");
            Console.Write("Digite aqui o nome do produto:");
            NewPdt.namePdt = Console.ReadLine();
            Console.Write("Digite aqui o preço de {0}:", NewPdt.namePdt);
            NewPdt.precoPdt = double.Parse(Console.ReadLine());
            Console.Write("Digite aqui a quantidade de {0}:", NewPdt.namePdt);
            NewPdt.qntPdt = int.Parse(Console.ReadLine());
            Console.Clear();
            Manipulation Insert = new Manipulation();
            Insert.InsertPdt(NewPdt.namePdt, NewPdt.precoPdt, NewPdt.qntPdt);

        }

        public static void ChangePdt()
        {

            Produto pdt = new Produto();

            Console.WriteLine("Editar Produto ------");
            Console.Write("Digite o código do produto que deseja alterar:");
            pdt.codePdt = int.Parse(Console.ReadLine());
            Console.Write("Digite o novo nome do produto:");
            pdt.namePdt = Console.ReadLine();
            Console.Write("Digite o novo preço do produto:");
            pdt.precoPdt = double.Parse(Console.ReadLine());
            Console.Write("Digite a nova quantidade do produto:");
            pdt.qntPdt = int.Parse(Console.ReadLine());
            Manipulation Charge = new Manipulation();
            Charge.UpdatePdt(pdt.codePdt, pdt.namePdt, pdt.precoPdt, pdt.qntPdt);
            Console.Clear();

        }

        public static void RemovePdt()
        {

            Produto produto = new Produto();

            Console.WriteLine("Remover Produto ------");
            Console.Write("Digite o código do produto:");
            produto.codePdt = int.Parse(Console.ReadLine());
            Manipulation Remover = new Manipulation();
            Remover.RemovePdt(produto.codePdt);
            Console.Clear();

        }

        public static void ListerPdt()
        {
            Console.WriteLine("Lista dos Produto ------");
            Manipulation Listar = new Manipulation();
            Listar.SelectPdt();
            Console.ReadKey();
            Console.Clear();
        }

    }
}
