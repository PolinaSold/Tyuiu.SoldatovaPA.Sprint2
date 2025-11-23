using System;
using Tyuiu.SoldatovaPA.Sprint2.Task1.V23.Lib;

namespace Tyuiu.SoldatovaPA.Sprint2.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №2 | Вариант 23 | ИСПБ-25-1                  *");
            Console.WriteLine("* Операции сравнения и логические операции        *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу из операций сравнений и      *");
            Console.WriteLine("* логических операций, которая вернет логическую  *");
            Console.WriteLine("* последовательность:                             *");
            Console.WriteLine("* (False, False, False, True, True, True)         *");
            Console.WriteLine("* при a = 242, b = 571, c = 325, d = 155          *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("***************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
            Console.WriteLine("***************************************************");

            bool[] results = ds.GetLogicOperations(a, b, c, d);

            Console.Write("Логическая последовательность: (");
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write(results[i]);
                if (i < results.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(")");

            Console.ReadKey();
        }
    }
}
