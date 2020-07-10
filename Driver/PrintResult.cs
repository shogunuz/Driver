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
            Console.WriteLine("\n\t***Процесс вычисления***");

            Task task = Task.Factory.StartNew(Sleeping);
            task.Wait();

            TestStand.TemperatureOverheated += TempOverheatedMsg;
            TestStand.TimeOver += TimeOverMsg;

            Console.WriteLine("\n\t***Результат***");

            TestStand.GetResult(te);
        }
        private static void Sleeping()
        {
            Console.Write("Подождите, пожалуйста, производится вычисление");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
        private static void TempOverheatedMsg(string msg)
            => Console.WriteLine(msg);
        
        
        private static void TimeOverMsg(string msg)
            => Console.WriteLine(msg);
        

    }
}
