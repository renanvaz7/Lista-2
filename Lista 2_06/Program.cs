using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double Tprestaçoes, Ppagas, Vprestaçao, VTpago, Sdevedor;

            Console.WriteLine("Digite o total de prestações");
            Tprestaçoes = Double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o total de prestações pagas");
            Ppagas = Double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o valor da prestação");
            Vprestaçao = Double.Parse(Console.ReadLine());
            Console.Clear();

            VTpago = Ppagas * Vprestaçao;
            Console.WriteLine("O valor pago é de: R$" + VTpago);
            Console.WriteLine();

            Sdevedor = ((Tprestaçoes * Vprestaçao) - (Ppagas * Vprestaçao));

            Console.WriteLine("O saldo devedor é de: R$" + Sdevedor);

            Console.ReadLine();
        }
    }
}
