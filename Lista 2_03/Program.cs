using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            A = 10;
            B = 20;

            Console.WriteLine("Valor de A é: " + A);
            Console.WriteLine();

            Console.WriteLine("Valor de B é: " + B);
            Console.WriteLine();

            Console.WriteLine("Aperte enter para trocar os valores");
            Console.ReadLine();

            Console.Clear();

            C = A;
            A = B;
            B = C;

            Console.WriteLine("Os valores foram trocados");
            Console.WriteLine();

            Console.WriteLine("Valor de A é: " + A);
            Console.WriteLine();

            Console.WriteLine("Valor de B é: " + B);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
