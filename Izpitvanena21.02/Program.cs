using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvanena21._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            AverageNumbers(numbers);
            PrintAll(numbers);
            CountZeros(numbers);
            PrintRow(numbers);
        }

        private static void PrintRow(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} ");
            }
        }

        private static void CountZeros( int[] numbers)
        {
            byte count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Broqt na nulite v masiva e {count}");
        }

        private static void PrintAll(int[] numbers)
        {
            Console.WriteLine();
        }

        private static void AverageNumbers(int[] numbers)
        {
            
            return;
        }
    }
}
