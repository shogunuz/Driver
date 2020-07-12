using Driver.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Driver
{
    class WaitingForCalculation
    {
        private static int time = 500; // 500 милли секунд

        public static void CalculationSimulation()
        {
            Task task = Task.Factory.StartNew(Sleeping);
            task.Wait();
        }

        private static void Sleeping()
        {
            Console.Write(ConstText.TimeForCalcSimulationString);
            for (int i = 0; i < CarEngine.MaxTime / time + 1; i++)
            {
                Console.Write(".");
                Thread.Sleep(time);
            }
            Console.WriteLine();
        }
    }
}
