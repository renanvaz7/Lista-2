using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sfixo, Comissao, Venda, Stotal;

            Sfixo = 800;
            Comissao = 15 / 100;

            Console.WriteLine("Digite o valor das vendas");
            Venda = Double.Parse(Console.ReadLine());

            Console.Clear();

            Stotal = (Sfixo + (Venda + Comissao));

            Console.WriteLine("O salário total é de: " + Stotal);

            Console.ReadLine();
        }
    }
}
