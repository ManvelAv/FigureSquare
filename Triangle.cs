namespace FigureSquare
{
    internal class Triangle : IAreaCalculate, IRightAngleChek
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public void Input()
        {
            do
            {
                Console.WriteLine("Введите сторону A: ");
            } while (!double.TryParse(Console.ReadLine(), out sideA));

            do
            {
                Console.WriteLine("Введите сторону B: ");
            } while (!double.TryParse(Console.ReadLine(), out sideB));

            do
            {
                Console.WriteLine("Введите сторону C: ");
            } while (!double.TryParse(Console.ReadLine(), out sideC));


            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB || sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Ошибка размеров сторон треугольника");
                return;
            }
        }

        public double CalculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
        }

        

        public bool RightAngleChek()
        {
            return (sideA * sideA + sideB * sideB == sideC * sideC) ||
                   (sideA * sideA + sideC * sideC == sideB * sideB) ||
                   (sideC * sideC + sideB * sideB == sideA * sideA);
        }
    }

}
