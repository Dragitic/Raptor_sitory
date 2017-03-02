using System;
using Delegate.delegates;

namespace Delegate
{
    public delegate void Foo(string message);
    class Program
    {
        public delegate void ConsoleOutput();
        private static readonly bool write = false;

        static void Main(string[] args)
        {
            Foo myFoo;

            if (write)
            {
                myFoo = SimpleDelegate.OutputToFile;
            }
            else
            {
                myFoo = SimpleDelegate.OutputToConsole;
            }

            SimpleDelegate.Info(2, 3, myFoo);

            ConsoleOutput consoleOutput = ComplexDelegate.HelloWorld;
            consoleOutput += ComplexDelegate.HowdyWorld;

            consoleOutput();

            Foo MyFoo = delegate (string M)
            {
                Console.WriteLine(M);
            };

            MyFoo("John Cena");
            Console.Read();
        }
    }
}
