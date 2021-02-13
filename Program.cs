using System;

namespace ImageComparer
{
    class Program
    {
        // interessant: https://docs.microsoft.com/de-de/archive/msdn-magazine/2019/march/net-parse-the-command-line-with-system-commandline
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"args count {args.Length}:");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            
        }

        internal static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}
