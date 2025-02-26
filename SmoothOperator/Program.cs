using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            sbyte n = sbyte.Parse(Console.ReadLine());

            --n;
            Console.WriteLine(n);
            ++n;
            Console.WriteLine(n);
        }
    }
}
