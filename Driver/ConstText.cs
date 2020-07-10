using Driver.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Driver
{
    class ConstText
    {
        public const string CalculatingResult = "Вычисляется результат";
        public const string EnterTemperature = "Введите температуру среды: ";
        public const string TEvnBiggerThanEngineTemp = "Температура среды превышает температуру перегрева двигателя!";
        public static string WrongNumber = $"Ошибочный ввод температуры. Пожалуйста, введите цифры от 1 до температуры перегрева({CarEngine.T}).";
        public static string TimeOverText(int time, double tmpEngine) 
        {
            return $"Время на тест истекло: {time} секунд || Температура двигателя: {tmpEngine}";
        }
        public static string TempOverheatedText(int time, double tmpEngine)
        {
            return $"Температура двигателя превысила {CarEngine.T} и достигла {tmpEngine}'С за {time} секунд";
        }
           
    }
}
