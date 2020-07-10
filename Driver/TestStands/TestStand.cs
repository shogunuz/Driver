
using Driver.Data;
using Driver.TestStands;
using System;

namespace Driver
{
    class TestStand : GeneralTestStand
    {
        public delegate void EngineHandler(string msg);
        public static event EngineHandler TimeOver;
        public static event EngineHandler TemperatureOverheated;

        private static int TimeLimit = 3000;
        private static double a(double m, int i)
        {
            return m/i;
        }

        public static void GetResult(double TEnv)
        {
            int i = 0;
            int time = 0;
            double tmpEngine = TEnv;
            double M = CarEngine.M[i], V = CarEngine.V[i];

            while ((CarEngine.T - tmpEngine)>0.01 && time < TimeLimit) 
            {
                V += a(M,CarEngine.I);

                tmpEngine += 
                    CarEngine.GetVh(CarEngine.M[i], CarEngine.V[i]) 
                    + CarEngine.GetVc(TEnv, tmpEngine);

                M = ((V - CarEngine.V[i]) / (CarEngine.V[i + 1] - CarEngine.V[i]))
                    * (CarEngine.M[i + 1] - CarEngine.M[i]) + CarEngine.M[i];

                if (i < CarEngine.V.Length - 2)
                    i += V<CarEngine.V[i+1]?0:1;

                time++;
            }
             
            if (time >= 2000)
                TimeOver(ConstText.TimeOverText(time, tmpEngine));
            else
                TemperatureOverheated(ConstText.TempOverheatedText(time, tmpEngine));
        }
    }
}
