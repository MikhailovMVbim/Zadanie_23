using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
 */

namespace Zadanie_23
{
    class Program
    {
        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {f}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 23. АСИНХРОННОЕ ПРОГРАММИРОВАНИЕ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.Write("Введите число для вычисления его факториала: ");
            int num = Convert.ToInt32(Console.ReadLine());

            FactorialAsync(num);

            Console.WriteLine("Main окончил работу!");
            Console.ReadKey();
        }

        static async void FactorialAsync(int n)
        {
            Console.WriteLine("Начало вычислений...");
            await Task.Run(() => Factorial(n));
            Console.WriteLine("Конец вычислений...");
        }
    }
}
