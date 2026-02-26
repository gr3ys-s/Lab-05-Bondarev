using ConsoleAppTeam.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTeam.Factorial_Modules;

namespace ConsoleAppTeam
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №5. Вариант 3");

            /// тут факториал
            FactorialInputModule.LogicFactorial();

            #region
            int[] array = InputModule.ReadArray("Введите числа для массива (Enter, чтобы остановиться): ");
            if (ValidationModule.CheckArray(array))
            {
                Console.Write("Ваш массив: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                ProcessingModule.FindMin(array);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
