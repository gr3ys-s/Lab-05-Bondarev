using System;

namespace ConsoleAppTeam.Factorial_Modules
{
    public class FactorialValidationModule
    {
        /// <summary>
        /// Проверка на коррекность числа (если оно < 0, то факториал нельзя определить)
        /// </summary>
        /// <param name="number">число для расчета факториала</param>
        /// <returns></returns>
        public static bool CheckNumber(int number)
        {
            return number >= 0;
        }
    }
}
