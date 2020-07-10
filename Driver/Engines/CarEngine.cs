using Driver.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace Driver.Data
{
    class CarEngine : GeneralEngine
    {
        public const int I = 10;

        public static int[] M = new int[] { 20, 75, 100, 105, 75, 0 };
        public static int[] V = new int[] { 0, 75, 150, 200, 250, 300 };

        public const int T = 110;
        public const double Hm = 0.01;
        public const double Hv = 0.0001;
        public const double C = 0.1;

        internal static double GetVh(double M, double V)
        {
            return M * CarEngine.Hm + Math.Pow(V, 2) * CarEngine.Hv;
        }

        internal static double GetVc(double TempEnv, double TempEngine)
        {
            return CarEngine.C * (TempEnv - TempEngine);
        }

    }
}
