using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    internal class Triangle
    {
        public static void PrintSqr()
        {
            Console.WriteLine("Вы выбрали треугольник\nДля выхода нажмите Escape\nтеперь введите значения сторон ");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                try
                {
                    Console.WriteLine("Введите сторону A: ");
                    if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0)
                    {
                        Console.WriteLine("Некорректный ввод. Введите положительное число.");
                        continue;
                    }

                    Console.WriteLine("Введите сторону B: ");
                    if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0)
                    {
                        Console.WriteLine("Некорректный ввод. Введите положительное число.");
                        continue;
                    }

                    Console.WriteLine("Введите сторону C: ");
                    if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0)
                    {
                        Console.WriteLine("Некорректный ввод. Введите положительное число.");
                        continue;
                    }

                    if (!IsValidTriangle(a, b, c))
                    {
                        Console.WriteLine("Ошибка размеров сторон");
                        continue;
                    }

                    double p = (a + b + c) / 2;
                    double sqr = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    Console.WriteLine($"Площадь треугольника = {sqr}");

                    Console.WriteLine("Проверить на прямой угол?\n Y - да");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        if (IsRightAngledTriangle(a, b, c))
                        {
                            Console.WriteLine("Треугольник является прямоугольным");
                        }
                        else
                        {
                            Console.WriteLine("Треугольник не прямоугольный");
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное значение сторон треугольника");
                    continue;
                }
            }
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && (a + b > c && b + c > a && a + c > b);
        }

        private static bool IsRightAngledTriangle(double a, double b, double c)
        {
            return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);
        }
    }

}
