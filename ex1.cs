using System;

namespace ConsoleApp
{
    public class Program
    {
        public delegate decimal CalcularDesconto(decimal preco);

        public static decimal DescontoDez(decimal preco)
        {
            return preco * 0.90m;
        }

        public static void Main(string[] args)
        {
            Console.Write("Digite o preço do produto: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            CalcularDesconto desconto = DescontoDez;

            decimal precoFinal = desconto(preco);

            Console.WriteLine("Preço com desconto: R$ " + precoFinal);
        }
    }
}
