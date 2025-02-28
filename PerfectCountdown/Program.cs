using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Start number: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Step number: ");
                int step = int.Parse(Console.ReadLine());

                if (start <= 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }
                if (step <= 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }
                if (step >= start)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                    continue;
                }
                if (start % step != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
                else
                {
                    for (int i = start; i >= 0; i -= step)
                        Console.WriteLine($"{i}");
                    break;
                }
            }
        }
    }
}
