using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeam.Modules
{
    public static class ValidationModule
    {
        public static bool CheckArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Массив пуст.");
                return false;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine("Найдено отрицательное число в массиве, вычисление воспроизводится не будет.");
                    return false;
                }
            }
            return true;
        }
    }
}
