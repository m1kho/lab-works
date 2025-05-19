using System;

namespace GeometryLibrary
{
    public class Trapezoid : Figure
    {
        public Trapezoid() : base() {}

        public Trapezoid(double[] x, double[] y) : base(x, y) {}

        private double Distance(int i, int j)
        {
            return Math.Sqrt(Math.Pow(x[j] - x[i], 2) + Math.Pow(y[j] - y[i], 2));
        }

        public double SideLength(int index1, int index2)
        {
            return Distance(index1, index2);
        }

        public double Perimeter()
        {
            return Distance(0, 1) + Distance(1, 2) + Distance(2, 3) + Distance(3, 0);
        }

        public double Area()
        {
            double base1 = Distance(0, 1);
            double base2 = Distance(2, 3);
            double height = Math.Abs(y[0] - y[2]); // працює, якщо вершини задано правильно
            return 0.5 * (base1 + base2) * height;
        }
    }
}
