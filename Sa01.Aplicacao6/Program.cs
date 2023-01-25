using System;

namespace Sa01.Aplicacao6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Calcular o total geral: preco x valor-unitário de uma frota de aviões.

            double[] precoAviao = new double[];
            int[] valorUnitario = new int[];
            double totalGeral;
            string resp = "";

            while (true)
            {
                for (int i = 0; i < precoAviao.Length; i++)
                {
                    Console.Write($"Informe o valor do {i + 1} Avião R$ ");
                    precoAviao[i] = double.Parse(Console.ReadLine());

                    for (int j = 0; j < UPPER3; j++)
                    {
                        
                    }
                }
            }

        }
    }
}