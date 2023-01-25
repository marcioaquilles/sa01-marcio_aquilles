using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Somar o valor de dois aviões.

            double valorAviao1, valorAviao2, valorTotal;

            Console.Write("Inform o valor do Primeiro Avião: ");
            valorAviao1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do Segundo Avião: ");
            valorAviao2 = double.Parse(Console.ReadLine());

            valorTotal = valorAviao1 + valorAviao2;

            Console.WriteLine();
            var e = new String('=', 36);
            Console.WriteLine(e);
            Console.Write($" Valor dos Aviões R$ {valorTotal.ToString("N2")} Reais\n");
            Console.WriteLine(e);
        }
    }
}