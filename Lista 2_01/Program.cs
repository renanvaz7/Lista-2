using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vpago, Pproduto, troco;

            Console.WriteLine("Digite o preço do produto");
            Pproduto = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite o valor pago");
            Vpago = Int32.Parse(Console.ReadLine());

            Console.Clear();

            troco = (Vpago - Pproduto);

            Console.WriteLine("O troco a ser dado é de: " + troco);

            Console.ReadLine();
        }
    }
}
