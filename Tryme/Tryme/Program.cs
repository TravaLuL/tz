using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tryme
{
    class Sred
    {
        static void Main(string[] args)
        {

            int delenie = 2;


            Console.WriteLine("Напишите первое число :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите Второе число :");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = (a + b) / delenie;
            Console.WriteLine("Среднее арифметическое чисел = " + sum);



        }
    }
    
  
}

