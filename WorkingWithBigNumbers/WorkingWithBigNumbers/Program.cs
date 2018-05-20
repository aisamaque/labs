using System;
using System.Diagnostics;
using System.Numerics;

namespace WorkingWithBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1024;
            int exponent = 2048;
            BigInteger result = new BigInteger();

            Statistic a = RunWithSatistics(() =>
            {
                result = BigInteger.Pow(number, exponent);
            }, "Pow");

            Console.WriteLine("Result:");
            Console.WriteLine(result.ToString());
            Console.WriteLine("#######################");
            Console.WriteLine("ElapsedTime");
            Console.WriteLine("Seconds: {0}", a.Time.TotalSeconds);
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }

        public static Statistic RunWithSatistics(Action Run, string StatisticName)
        {
            Stopwatch time = Stopwatch.StartNew();
            Run.Invoke();
            time.Stop();
            return new Statistic { Name = StatisticName, Time = time.Elapsed };
        }
    }

    public class Statistic
    {
        public string Name { get; set; }
        public TimeSpan Time { get; set; }

        public Statistic()
        {

        }
    }
}
