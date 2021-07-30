using System;
using Library;
using static System.Console;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryTest item = new LibraryTest();
            WriteLine(item.PrimeFactors(10));
        }
    }
}
