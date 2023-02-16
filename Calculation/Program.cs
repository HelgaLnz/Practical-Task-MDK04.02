using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding= Encoding.UTF8;
                Console.Write("Введите число a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите действие: " +
                    "\t\n1 - сложить" +
                    "\t\n2 - умножить" +
                    "\t\n3 - разделить" +
                    "\t\n4 - вычесть" +
                    "\t\n5 - корень b степени числа a" +
                    "\t\n6 - a в степени b " +
                    "\t\n7 - найти максимальное число" +
                    "\t\n8 - найти минимальное число ");
                Console.Write("Действие: ");
                int sym = Convert.ToInt32(Console.ReadLine());
                var result = new Program().Options(a, b, sym);
                Console.WriteLine();
                Console.WriteLine("Результат: " + result);
                Console.WriteLine("\n---------------------------------------------\n");
            }
        }
        public int Options(int a, int b, int sym)
        {
            var result = 0;
            if (sym == 1)
                result = a + b;
            else if (sym == 2)
                result = a * b;
            else if (sym == 3)
                result = a / b;
            else if (sym == 4)
                result = a - b;
            else if (sym == 5)
                result = Convert.ToInt32(Math.Pow(a, 1 / b));
            else if (sym == 6)
                result = Convert.ToInt32(Math.Pow(a, b));
            else if (sym == 7)
                result = Math.Max(a, b);
            else if (sym == 8)
                result = Math.Min(a, b);
            return result;
        }
    }
}
