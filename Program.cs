namespace FigureSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру : ");
            Console.WriteLine("Круг - нажмите 1\nТреугольник - нажмите 2");
            ShapeCalculator calculator = new ShapeCalculator();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
               
                int x;
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    continue;
                }
                IAreaCalculate shape;
                switch (x)
                {
                    case 1:
                        shape = new Circle();
                        break;
                    case 2:
                        shape = new Triangle();
                        break;
                    default:
                        continue;
                }
                calculator.PrintSqr(shape);
            }
        }
    }
}
