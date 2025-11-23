using System;
using Tyuiu.SoldatovaPA.Sprint2.Task2.V22.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №2 | Вариант 22 | ИСПБ-25-1                  *");
            Console.WriteLine("* Проверка попадания точки в заштрихованную область*");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает целые   *");
            Console.WriteLine("* значения с клавиатуры и вычисляет находится ли  *");
            Console.WriteLine("* точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите координату X (1-15): ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите координату Y (1-15): ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (x < 1 || x > 15 || y < 1 || y > 15)
                {
                    Console.WriteLine("Ошибка: координаты должны быть в диапазоне от 1 до 15.");
                }
                else
                {
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                    Console.WriteLine("***************************************************");

                    bool result = ds.CheckDotInShadedArea(x, y);

                    if (result)
                    {
                        Console.WriteLine($"Точка с координатами ({x},{y}) находится в заштрихованной области");
                    }
                    else
                    {
                        Console.WriteLine($"Точка с координатами ({x},{y}) НЕ находится в заштрихованной области");
                    }
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
