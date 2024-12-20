using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ValueInSeconds;
            Console.WriteLine("Добро пожаловать!\nВведите, сколько нужно конвертировать: ");
            ValueInSeconds = Convert.ToInt32(Console.ReadLine());
            int min = ValueInSeconds / 60;
            int hour = min / 60;
            int days = hour / 24;

            Console.WriteLine($"{ValueInSeconds} - это {days} дней {hour} часов и {min} минут");
            Console.ReadLine();
        }
    }
}
