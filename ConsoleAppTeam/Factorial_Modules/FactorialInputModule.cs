using System;

namespace ConsoleAppTeam.Factorial_Modules
{
    public class FactorialInputModule
    {
        /// <summary>
        /// Ввод числа для поиска факториала и реализация логики его расчета
        /// </summary>
        public static void LogicFactorial()
        {
            //число
            int number;
            //получение значения числа
            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            //реализация логики
            if (FactorialValidationModule.CheckNumber(number))
            {
                Console.WriteLine($"Результат факториала: {FactorialProcessingModule.GetFactorial(number)}");
            }
            else
            {
                Console.WriteLine("Факториал отрицательного числа не определен");
            }
        }
    }
}
