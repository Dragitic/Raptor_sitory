using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbaPierwszaVolTwo
{
    class Program
    {
        private static List<bool> primeNumbersList;
        private static int sieveOfEratostehnesIterator = 2;
        private static int iterator = sieveOfEratostehnesIterator;
        private static int loopNumber;
        private static bool end;
        static void Main(string[] args)
        {
            var sqrt = Math.Sqrt(10000);
            loopNumber = int.Parse(Math.Floor(sqrt).ToString());
            primeNumbersList = primeNumbersListGenerator(10000);

            SieveOfEratosthenes();
            Console.ReadLine();
        }

        private static void SieveOfEratosthenes()
        {
            for (var i = 2; i < primeNumbersList.Count; i++)
            {
                if (iterator > loopNumber)
                {
                    DisplayPrimeNumbers();
                    end = true;
                    return;
                }
                sieveOfEratostehnesIterator += iterator;
                if (sieveOfEratostehnesIterator >= primeNumbersList.Count)
                    FindNewIterator();
                primeNumbersList[sieveOfEratostehnesIterator] = false;
                if (end)
                    return;
            }
        }

        private static void DisplayPrimeNumbers()
        {
            for (var i = 1; i < primeNumbersList.Count; i++)
            {
                Console.WriteLine(primeNumbersList[i] == false ? "NIE" : "TAK");
            }
        }

        private static void FindNewIterator()
        {
            for (var i = iterator; i < primeNumbersList.Count; i++)
            {
                if (i != iterator)
                {
                    if (primeNumbersList[i])
                    {
                        sieveOfEratostehnesIterator = i;
                        iterator = i;
                        SieveOfEratosthenes();
                        if (end)
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
