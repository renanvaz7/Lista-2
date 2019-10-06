using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg, qntd, Vfinal;

            Console.WriteLine("Digite o preço do quilo do produto");
            kg = Double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite a quantidade de quilos consumida");
            qntd = Double.Parse(Console.ReadLine());

            Console.Clear();

            Vfinal = (kg * qntd);

            Console.WriteLine("O valor a ser pago é de: R$" + Vfinal);

            Console.ReadLine();
        }
    }
}
