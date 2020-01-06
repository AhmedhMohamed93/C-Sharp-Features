using System;
using System.Threading;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Calc(10,2);
            Console.WriteLine("Results is \nSum: " + res.Item1 + "\nDiff: " + res.Item2 + "\nMul: "+ res.Item3 + "\nDiv: " + res.Item1);
            Thread.Sleep(5000);
        }


        static Tuple<int, int, int, int> Calc(int num1, int num2)
        {
            Tuple<int, int, int, int> results = 
                new Tuple<int, int, int, int>(num1+num2, num1 - num2, num1 * num2, num1 / num2);

            return results;
        }

    }
}