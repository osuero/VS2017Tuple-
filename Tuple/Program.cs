using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            NewTuple();


            Console.WriteLine("Hello World!");
        }

        private static void NewTuple()
        {
            var tupleTest = new Tuple<int, int, string>(2,2, "---->The two first were numbers----");

            Console.WriteLine("Using Tuple with new \n");
            Console.WriteLine("\n Result of tuples: {0} this is an interger type, {1} this one is also an interger type, finally this is an string type {2}", tupleTest.Item1.ToString(), tupleTest.Item2.ToString(), tupleTest.Item3);
            Console.ReadKey();
        }
    }
}
