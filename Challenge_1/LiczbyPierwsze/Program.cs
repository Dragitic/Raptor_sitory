using System;
using System.Collections.Generic;

namespace LiczbyPierwsze
{
    class Program
    {
        private static List<bool> numbers;
        private static List<string> primeNumbers = new List<string>();
        private static int sieveOfEratostehnesIterator = 2;
        private static int iterator = sieveOfEratostehnesIterator;
        private static int loopNumber;
        private static bool end;
        static void Main(string[] args)
        {
            var input = 10000;
            var sqrt = Math.Sqrt(input);
            loopNumber = int.Parse(Math.Floor(sqrt).ToString());
            numbers = primeNumbersListGenerator(input);

            SieveOfEratosthenes();

            Console.WriteLine("Input:");
            var loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                var number = int.Parse(Console.ReadLine());
                primeNumbers.Add(numbers[number] ? "TAK" : "NIE");
            }
            Console.WriteLine();
            Console.WriteLine("Output:");
            foreach (var primeNumber in primeNumbers)
            {
                Console.WriteLine(primeNumber);
            }
            Console.ReadLine();
        }

        private static void SieveOfEratosthenes()
        {
            for (var i = 2; i < numbers.Count; i++)
            {
                if (iterator > loopNumber)
                {
                    end = true;
                    return;
                }
                sieveOfEratostehnesIterator += iterator;
                if (sieveOfEratostehnesIterator >= numbers.Count)
                    FindNewIterator();
                numbers[sieveOfEratostehnesIterator] = false;
                if (end)
                    return;
            }
        }

        private static void FindNewIterator()
        {
            for (var i = iterator; i < numbers.Count; i++)
            {
                if (i != iterator)
                {
                    if (numbers[i])
                    {
                        sieveOfEratostehnesIterator = i;
                        iterator = i;
                        SieveOfEratosthenes();
                        if(end)
                            return;
                    }
                }
            }
        }

        private static List<bool> primeNumbersListGenerator(int number)
        {
            var primeNumersList = new List<bool>();
            for (var i = 0; i <= number; i++)
            {
                primeNumersList.Add(i > 1);
            }
            return primeNumersList;
        }
    }
}
