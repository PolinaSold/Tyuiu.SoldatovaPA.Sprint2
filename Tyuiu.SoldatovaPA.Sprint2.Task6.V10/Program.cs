using System;
using Tyuiu.SoldatovaPA.Sprint2.Task6.V10.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №2 | Вариант 10 | ИСПБ-25-1                  *");
            Console.WriteLine("* Определение даты предыдущего дня                *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая использует          *");
            Console.WriteLine("* сокращенную форму записи оператора switch       *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает       *");
            Console.WriteLine("* результат.                                      *");
            Console.WriteLine("* Дата характеризуется: g (год), m (месяц), n (число)*");
            Console.WriteLine("* По заданным g, n и m определить дату предыдущего дня*");
            Console.WriteLine("* Заданный год не является високосным.            *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите год (g): ");
                int g = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите месяц (m, 1-12): ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число (n): ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (g > 0 && m >= 1 && m <= 12 && n >= 1 && n <= 31)
                {
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                    Console.WriteLine("***************************************************");

                    string result = ds.FindDateOfPreviousDay(g, m, n);
                    Console.WriteLine($"Дата предыдущего дня: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: некорректные данные.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целые числа.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
