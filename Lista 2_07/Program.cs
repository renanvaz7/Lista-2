using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestaçao, valor, taxa, tempo;

            Console.WriteLine("Digite o valor da prestação");
            valor = Double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a taxa de juros do banco");
            taxa = Double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o número de dias em atraso");
            tempo = Double.Parse(Console.ReadLine());
            Console.Clear();

            prestaçao = valor + (valor * (taxa / 100) * tempo);

            Console.WriteLine("O valor da prestação em atraso é de: R$" + prestaçao);

            Console.ReadLine();
        }
    }
}
