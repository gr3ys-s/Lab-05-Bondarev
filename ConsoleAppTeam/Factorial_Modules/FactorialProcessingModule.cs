using System;
using System.Diagnostics;

namespace ConsoleAppTeam.Factorial_Modules
{
    public class FactorialProcessingModule
    {
        /// <summary>
        /// Расчет факториала
        /// </summary>
        /// <param name="number">число для расчета факториала</param>
        /// <returns>возвращает число (значение факториала)</returns>
        public static long GetFactorial(int number)
        {
            long result;

            if (number < 0)
            {
                Console.WriteLine("Факториал отрицательного числа не определен");
                result = 0;
            }

            if (number == 0 || number == 1)
            {
                result = 1;
                return result;
            }

            result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
                Debug.WriteLine(result);
            }
            return result;
        }
    }
}
