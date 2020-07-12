using Driver.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Driver
{
    class PrintResult
    {
      
        /* 
          Можно было бы просто вывести WriteLine"ом сообщения,
          но я решил воспользоваться событиями (пускай и незначительно). 
        
        Для более правдоподобной симуляции вычисления я воспользовался тасками,
        задав искусственную паузу для вторичного потока, но при этом  говорю 
        главному потоку, чтобы тот подождал завершения task
        */
        public static void PrintData(double te)
        {
            Console.WriteLine($"\n{ConstText.TimeForResearchString} {CarEngine.MaxTime} с");
            Console.WriteLine($"\n\t{ConstText.CalculationProcessString}");

            WaitingForCalculation.CalculationSimulation();

            TestStand.TemperatureOverheated += (msg) => { Console.WriteLine(msg); };
            TestStand.TimeOver += (msg) => Console.WriteLine(msg);

            Console.WriteLine($"\n\t{ConstText.ResultString}");

            TestStand.GetResult(te);
        }
        

    }
}
