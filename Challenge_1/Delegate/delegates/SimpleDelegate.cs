using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.delegates
{
    public class SimpleDelegate
    {
        public static void OutputToConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static void OutputToFile(string message)
        {
            // zapisywanie do pliku
        }

        public static void Info(int x, int y, Foo myFoo)
        {
            myFoo("Rezultat: " + (x + y));
        }
    }
}