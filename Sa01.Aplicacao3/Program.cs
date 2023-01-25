using System;

namespace Sa01.Aplicacao3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // vai multiplicar a quantidade de assentos pela quantidade de aviões, considere
            // que cada avião possui 17 assentos

            int quantidaDeAvioes, quantidaDeAssentos, assentosPorAviao = 17;

            Console.Write("Informe a quantidade de aviões: ");
            quantidaDeAvioes = int.Parse(Console.ReadLine());

            quantidaDeAssentos = quantidaDeAvioes * assentosPorAviao;

            Console.WriteLine();
            var e = new String('=', 36);
            Console.WriteLine(e);
            Console.Write($" Quantidade total de assentos: {quantidaDeAssentos}\n");
            Console.WriteLine(e);
            Console.ReadLine();

        }
    }
}