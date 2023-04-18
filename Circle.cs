namespace FigureSquare
{
    class Circle
    {
        private const double PI = 3.1415;
        private static double radius;

        public static void PrintSqr()
        {
            Console.WriteLine("Вы выбрали круг");
            Console.WriteLine("Для выхода нажмите Escape\nВведите пожалуйста радиус круга\n ");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                    if (radius <= 0)
                    {
                        Console.WriteLine("Введите корректное значение радиуса ");
                        continue;
                    }

                    double sqr = PI * radius * radius;
                    Console.WriteLine($"Площадь круга = {sqr} см");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное значение радиуса");
                    continue;
                }
            }
        }
    }
}
