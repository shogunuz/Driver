using Driver.Data;
using System;
using System.Threading;

namespace Driver
{
    class Program
    {
        public int TEnvironment { get; set; }

        static void Main(string[] args)
        {
            Console.Write(ConstText.EnterTemperature);
            Double.TryParse(Console.ReadLine(), out double TempEnvironment);
            if (TempEnvironment >= 1 && TempEnvironment < CarEngine.T)
                PrintResult.PrintData(TempEnvironment);
            else if (TempEnvironment >= 1 && TempEnvironment > CarEngine.T)
                Console.WriteLine(ConstText.TEvnBiggerThanEngineTemp);
            else
                Console.WriteLine(ConstText.WrongNumber);

            Console.ReadKey();
        }
    }
}
