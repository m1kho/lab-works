namespace Lab3
{
    // Клас Point представляє точку на площині з координатами X та Y
    class Point
    {
        // Приватні поля для зберігання координат точки
        private double X;
        private double Y;

        // Геттер для отримання X
        public double GetX()
        {
            return X;
        }

        // Геттер для отримання Y
        public double GetY()
        {
            return Y;
        }

        // Конструктор з параметрами (за замовчуванням 0, 0)
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        // Конструктор копіювання з посиланням: копіює координати та обнуляє передану точку
        public Point(ref Point anotherPoint)
        {
            X = anotherPoint.X;
            Y = anotherPoint.Y;
            anotherPoint = null;
        }

        // Конструктор копіювання: створює копію точки
        public Point(Point other)
        {
            X = other.X;
            Y = other.Y;
        }

        // Деструктор: викликається при знищенні об'єкта
        ~Point()
        {
            Console.WriteLine("Destructor called");
        }

        // Статичний метод для обчислення відстані між двома точками
        public static double GetLength(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}