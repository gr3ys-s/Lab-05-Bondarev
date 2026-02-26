using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeam.Modules
{
    public static class InputModule
    {
        public static int[] ReadArray(string message)
        {
            Console.Write(message);
            int[] array;
            try
            {
                array = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                return array;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
                return null;
            }
        }
    }
}
