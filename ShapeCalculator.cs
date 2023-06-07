using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    internal class ShapeCalculator
    {
        public void PrintSqr(IAreaCalculate shape)
        {
            shape.Input();
            if (shape is IAreaCalculate areaShape)
            {
                double area = areaShape.CalculateArea();
                Console.WriteLine("Площадь фигуры = " + area);
            }
        }
    }
}
