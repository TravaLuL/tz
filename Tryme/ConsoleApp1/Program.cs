using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите Первое число :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите Второе число :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите Третье число :");
            int z = Convert.ToInt32(Console.ReadLine());
            int summa = (a + b + z);
            Console.WriteLine("Сумма чисел = " + summa);
            int multiply = (a * b * z);
            Console.WriteLine("Умножение чисел = " + multiply);




        }
    }
}
