using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = 32;
            Random rnd = new Random(seed);
            Stopwatch stopwatch = new Stopwatch();
            
            Console.WriteLine("Random.Next:");
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next());
            }
            Console.WriteLine();
            Console.WriteLine("Stopwatch time: " + stopwatch.Elapsed);
            Console.WriteLine();

            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine("RNGCryptoServiceProvider:");
            for (int i = 0; i < 10; i++)
            {
                int val = BitConverter.ToInt32(CustomRandom.GenerateRandomByteArray(seed), 0);
                Console.WriteLine(val);
            }
            Console.WriteLine();
            Console.WriteLine("Stopwatch time: " + stopwatch.Elapsed);

            Console.ReadKey();

        }
    }
}
