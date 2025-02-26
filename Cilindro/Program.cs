using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura do cilindro: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Raio do cilindro: ");
            double r = double.Parse(Console.ReadLine());
            double volume = Math.PI * Math.Pow(r, 2) * a;
            Console.WriteLine($"Volume do cilindro: {volume:F3} cm");
            double area = 2 * Math.PI * r * (r + a);
            Console.WriteLine($"Área da base do cilindro: {area:F3} cm²");
        }
    }
}
