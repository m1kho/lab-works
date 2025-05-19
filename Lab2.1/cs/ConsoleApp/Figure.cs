namespace GeometryLibrary
{
    public class Figure
    {
        protected double[] x;
        protected double[] y;

        public Figure()
        {
            x = new double[4];
            y = new double[4];
        }

        public Figure(double[] x, double[] y)
        {
            this.x = (double[])x.Clone();
            this.y = (double[])y.Clone();
        }

        public double GetX(int index) => x[index];
        public double GetY(int index) => y[index];
    }
}