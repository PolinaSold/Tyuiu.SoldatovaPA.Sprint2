using System;
using Tyuiu.SoldatovaPA.Sprint2.Task5.V2.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №2 | Вариант 2 | ИСПБ-25-1                   *");
            Console.WriteLine("* Определение времени года по месяцу              *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая использует оператор *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает*");
            Console.WriteLine("* результат.                                      *");
            Console.WriteLine("* По данному месяцу, определите в какую пору года *");
            Console.WriteLine("* попадает этот месяц (Зима, Лето, Весна, Осень). *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите номер месяца (1-12): ");
                int month = Convert.ToInt32(Console.ReadLine());

                if (month >= 1 && month <= 12)
                {
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                    Console.WriteLine("***************************************************");

                    string season = ds.FindMonthSeason(month);
                    Console.WriteLine($"Месяц {month} - это {season}");
                }
                else
                {
                    Console.WriteLine("Ошибка: номер месяца должен быть от 1 до 12.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число от 1 до 12.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
