using System;
using System.Linq;

namespace Sa01.Aplicacao6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Calcular o total geral: preco x valor-unitário de uma frota de aviões.
            double totalGeral = 0;
            int totalAvioes;

            Console.Write("Informe a quantidade de aviões da frota: ");
            totalAvioes = int.Parse(Console.ReadLine());

            double[] precoUnidade = new double[totalAvioes];

            int i = 0;

            while (i < totalAvioes)
            {
                Console.Write($"Informe o valor do {i + 1}o. Avião R$: ");
                precoUnidade[i] = double.Parse(Console.ReadLine());

                totalGeral += (precoUnidade[i]) * totalAvioes;

                i++;
            }

            Console.WriteLine();
            var e = new String('=', 44);
            Console.WriteLine(e);
            Console.Write($" Total Geral da Frota R$ {totalGeral.ToString("N2")} Reais\n");
            Console.WriteLine(e);
        }
    }
}