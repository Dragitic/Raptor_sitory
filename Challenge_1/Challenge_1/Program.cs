using System;
using System.Collections.Generic;
using System.Linq;
using ExtensionMethods;

namespace Challenge_1
{
    class Program
    {
        public delegate int Equation(string consoleInput);

        static void Main(string[] args)
        {
            var output = "Hate";

            Equation equation = SumNumber;
            equation += SubstractNumber;

            var input = Console.ReadLine();
            var result = equation(input);

            var result2 = equation(input);

            if (result == 6 || result2 == 6)
                output = "Love";

            Console.WriteLine(output);
            Console.ReadKey();
        }

        private static int SumNumber(string input) => input.Split(' ').Select(int.Parse).Sum();
        private static int SubstractNumber(string input) => input.Split(' ').Select(int.Parse).Substraction();
    }
}

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int Substraction(this IEnumerable<int> operation)
        {
            var enumerable = operation as int[] ?? operation.ToArray();
            var result = enumerable.ElementAt(0);

            for (var i = 1; i < enumerable.Length; i++)
            {
                result -= enumerable[i];
            }
            return result;
        }
    }
}

