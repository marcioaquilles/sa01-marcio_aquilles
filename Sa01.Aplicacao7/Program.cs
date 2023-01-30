using System;

namespace Sa01.Aplicacao7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Calcular a soma total de cinco peças no estoque da oficina de aeronaves.
                       
            double[] precoPeca = new double[5];
            double somaTotal = 0;

            for (int i = 0; i < precoPeca.Length; i++)
            {
                Console.Write($"Informe o valor da {i + 1}o. Peça R$: ");
                precoPeca[i] = double.Parse(Console.ReadLine());
                somaTotal += precoPeca[i];
            }

            Console.WriteLine();
            var e = new String('=', 42);
            Console.WriteLine(e);
            Console.Write($" Valor Total das Peças R$ {(somaTotal).ToString("N2")} Reais\n");
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}