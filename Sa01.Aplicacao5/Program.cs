using System;

namespace Sa01.Aplicacao5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Calcular a média total do faturamento trimestral da VoeAirlines.

            double mes1, mes2, mes3, mediaTotal;
            
            Console.Write("Informe o faturamento do mês 1 R$: ");
            mes1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o faturamento do mês 2 R$: ");
            mes2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o faturamento do mês 3 R$: ");
            mes3 = double.Parse(Console.ReadLine());

            mediaTotal = (mes1 + mes2 + mes3) / 3;

            Console.WriteLine();
            var e = new String('=', 36);
            Console.WriteLine(e);
            Console.Write($" Média do Faturamento R$ {mediaTotal.ToString("N2")} Reais\n");
            Console.WriteLine(e);
            Console.ReadLine();           

        }
    }
}