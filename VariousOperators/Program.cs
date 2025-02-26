using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            byte n = byte.Parse(Console.ReadLine());

            byte div = (byte)(n / 2);
            Console.WriteLine(div);
            byte shiftLeft = (byte)(n << 3);
            Console.WriteLine(shiftLeft);
            byte xor = (byte)(n ^ 6);
            Console.WriteLine(xor);
            bool isGreaterThanTen = n > 10;
            Console.WriteLine(isGreaterThanTen);
        }
    }
}
