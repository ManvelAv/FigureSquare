namespace FigureSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип фигуры: 1 - Круг, 2 - Треугольник");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Circle.PrintSqr();
                    break;
                }
                else if (input == "2")
                {
                    Triangle.PrintSqr();
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                }
            }

            Console.ReadKey();
        }
    }
}