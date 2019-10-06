using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo, cheque, Sfinal;

            saldo = 500;

            Console.WriteLine("Digite o valor do cheque");
            cheque = Double.Parse(Console.ReadLine());

            Console.Clear();

            Sfinal = (saldo + cheque);

            Console.WriteLine("O novo saldo é de: R$" + Sfinal);

            Console.ReadLine();
        }
    }
}
