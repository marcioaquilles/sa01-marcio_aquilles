using System;
using System.Globalization;
using System.Threading;

namespace Sa01.Aplicacao2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Diminuir o ano atual com o ano de lançamento do primeiro avião da Embraer.

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);

            int anoLancamento, anoAtual, diff;
            DateTime data = new DateTime(2023, 01, 24);
            anoAtual = data.Year;

            Console.Write("Informe o ano de Lançamento do 1o. Avião: ");
            anoLancamento = int.Parse(Console.ReadLine());
            diff = anoAtual - anoLancamento;

            Console.WriteLine();
            var e = new String('=', 56);
            Console.WriteLine(e);
            Console.Write($" Já se passaram {diff} anos em relação ao ano atual {anoAtual}\n");
            Console.WriteLine(e);
            Console.ReadLine();

        }
    }
}