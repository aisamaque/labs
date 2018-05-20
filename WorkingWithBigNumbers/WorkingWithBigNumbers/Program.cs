using System;
using System.Numerics;

namespace WorkingWithBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigIntegers requires System.Numerics;
            int number = 1024;
            int exponent = 2048;

            BigInteger result = BigInteger.Pow(number, exponent);
           
            Console.WriteLine(result.ToString());
            Console.WriteLine("#######################");
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}
