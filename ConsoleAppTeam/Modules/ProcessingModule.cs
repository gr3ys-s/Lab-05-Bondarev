using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeam.Modules
{
    public static class ProcessingModule
    {
        public static int FindMin(int[] array)
        {
            int minNumber = array.Min();
            Console.WriteLine("Минимум в массиве: " + minNumber);
            return minNumber;
        }
    }
}
