using System;
using Tyuiu.SoldatovaPA.Sprint2.Task4.V5.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №2 | Вариант 5 | ИСПБ-25-1                   *");
            Console.WriteLine("* Вычисление значения с тернарным оператором      *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое *");
            Console.WriteLine("* значение с использованием тернарного оператора, *");
            Console.WriteLine("* где пользователь вводит значение переменных x,y *");
            Console.WriteLine("* с клавиатуры. Ответ округлите до 3 знаков после *");
            Console.WriteLine("* запятой.                                        *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите значение X: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение Y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("***************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                Console.WriteLine("***************************************************");

                double z = ds.Calculate(x, y);
                Console.WriteLine($"Z = {z:F3}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите числовые значения.");
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
