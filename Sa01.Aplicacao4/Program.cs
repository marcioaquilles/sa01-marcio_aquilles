using System;

namespace Sa01.Aplicacao4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Dividir 5000 (cinco mil reais) para 10 clientes especiais da VoeAirlines.

            decimal valorEmCaixa = 5000.00m;
            int totalClientes = 10;
            decimal valor;

            valor = valorEmCaixa / totalClientes;

            Console.WriteLine();
            var e = new String('=', 50);
            Console.WriteLine(e);
            Console.Write($" Valor dividido para cada cliente R$ {valor.ToString("N2")} Reais\n");
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}