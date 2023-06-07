namespace FigureSquare
{
    class Circle : IAreaCalculate
    {
        private double _radius;
        const double PI = 3.1415;
        
        public double CalculateArea()
        {
            return PI * _radius * _radius;
        }

        public void Input()
        {
            do
            {
                Console.WriteLine("Введите пожалуйста радиус !");
            } while (double.TryParse(Console.ReadLine(), out _radius) == false); ;
        }
    }
}
