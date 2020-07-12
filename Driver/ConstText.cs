using Driver.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Driver
{
    class ConstText
    {
        public const string ResultString = "\n\t***Результат***";
        public const string CalculationProcessString = "\n\t***Процесс вычисления***";
        public const string TimeForCalcSimulationString = "Подождите, пожалуйста, производится вычисление";
        public const string TimeForResearchString = "Заданное время для исследования двигателя: ";
        public const string CalculatingResultString = "Вычисляется результат";
        public const string EnterTemperatureString = "Введите температуру среды: ";
        public const string TEvnBiggerThanEngineTempString = "Температура среды превышает температуру перегрева двигателя!";
        public static string WrongNumberString = $"Ошибочный ввод температуры. Пожалуйста, введите цифры от 1 до температуры перегрева({CarEngine.T}).";
        public static string TimeResultString = "Двигатель машины не перегреется за данное время!";
        public static string TimeOverText(int time, double tmpEngine) 
             => $"Время на тест истекло: {time} секунд || " +
            $"Температура двигателя: {tmpEngine}\n{TimeResultString}";
        
        public static string TempOverheatedText(int time, double tmpEngine)
            => $"Температура двигателя превысила {CarEngine.T} и " +
            $"достигла {tmpEngine}'С за {time} с (секунда)";
        
           
    }
}
