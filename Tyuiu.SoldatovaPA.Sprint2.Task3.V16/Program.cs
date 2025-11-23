using System;
using Tyuiu.SoldatovaPA.Sprint2.Task3.V16.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №2 | Вариант 16 | ИСПБ-25-1                  *");
            Console.WriteLine("* Вычисление кусочной функции                     *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое *");
            Console.WriteLine("* значение функции Y с использованием вложенных   *");
            Console.WriteLine("* оператор if-else, где пользователь вводит       *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить   *");
            Console.WriteLine("* полученное значение до трех знаков после запятой*");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите значение X: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("***************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                Console.WriteLine("***************************************************");

                double y = ds.Calculate(x);
                Console.WriteLine($"Y = {y:F3}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите числовое значение.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
