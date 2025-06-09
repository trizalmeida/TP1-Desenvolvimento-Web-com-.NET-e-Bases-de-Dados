using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a base do retângulo: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Func<double, double, double> calcularArea = (baseRet, alturaRet) => baseRet * alturaRet;

        double area = calcularArea(b, h);

        Console.WriteLine("Área do retângulo: " + area);
    }
}
