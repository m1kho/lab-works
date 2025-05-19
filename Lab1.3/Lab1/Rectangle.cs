namespace Lab3
{
    // Клас Rectangle представляє прямокутник, заданий чотирма точками
    class Rectangle
    {
        // Публічні поля для зберігання чотирьох вершин прямокутника
        public Point Point1;
        public Point Point2;
        public Point Point3;
        public Point Point4;

        // Геттери для отримання кожної з точок
        public Point GetPoint1()
        {
            return Point1;
        }

        public Point GetPoint2()
        {
            return Point2;
        }

        public Point GetPoint3()
        {
            return Point3;
        }

        public Point GetPoint4()
        {
            return Point4;
        }

        // Конструктор за замовчуванням: створює прямокутник з новими точками
        public Rectangle()
        {
            Point1 = new Point();
            Point2 = new Point();
            Point3 = new Point();
            Point4 = new Point();
        }

        // Конструктор з параметрами: приймає чотири точки
        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            Point1 = p1;
            Point2 = p2;
            Point3 = p3;
            Point4 = p4;
        }

        // Конструктор копіювання з посиланням: копіює точки з іншого прямокутника та обнуляє його
        public Rectangle(ref Rectangle anotherRectangle)
        {
            Point1 = anotherRectangle.Point1;
            Point2 = anotherRectangle.Point2;
            Point3 = anotherRectangle.Point3;
            Point4 = anotherRectangle.Point4;
            anotherRectangle = null;
        }

        // Конструктор копіювання: створює копію прямокутника
        public Rectangle(Rectangle other)
        {
            Point1 = other.Point1;
            Point2 = other.Point2;
            Point3 = other.Point3;
            Point4 = other.Point4;
        }

        // Деструктор: викликається при знищенні об'єкта
        ~Rectangle()
        {
            Console.WriteLine("Destructor called");
        }

        // Метод для обчислення периметра прямокутника
        public double GetPerimeter()
        {
            double width = Point.GetLength(GetPoint1(), GetPoint2());
            double height = Point.GetLength(GetPoint2(), GetPoint3());
            return 2 * (width + height);
        }

        // Метод для обчислення площі прямокутника
        public double GetArea()
        {
            double width = Point.GetLength(GetPoint1(), GetPoint2());
            double height = Point.GetLength(GetPoint2(), GetPoint3());
            return width * height;
        }

        // Перевантаження оператора "-" для віднімання числа від координат точок прямокутника
        public static Rectangle operator -(Rectangle r, double value)
        {
            return new Rectangle(
                new Point(r.GetPoint1().GetX() - value, r.GetPoint1().GetY() - value),
                new Point(r.GetPoint2().GetX() - value, r.GetPoint2().GetY() - value),
                new Point(r.GetPoint3().GetX() - value, r.GetPoint3().GetY() - value),
                new Point(r.GetPoint4().GetX() - value, r.GetPoint4().GetY() - value)
            );
        }

        // Перевантаження оператора "-" для віднімання координат точок іншого прямокутника
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(
                new Point(r1.GetPoint1().GetX() - r2.GetPoint1().GetX(), r1.GetPoint1().GetY() - r2.GetPoint1().GetY()),
                new Point(r1.GetPoint2().GetX() - r2.GetPoint2().GetX(), r1.GetPoint2().GetY() - r2.GetPoint2().GetY()),
                new Point(r1.GetPoint3().GetX() - r2.GetPoint3().GetX(), r1.GetPoint3().GetY() - r2.GetPoint3().GetY()),
                new Point(r1.GetPoint4().GetX() - r2.GetPoint4().GetX(), r1.GetPoint4().GetY() - r2.GetPoint4().GetY())
            );
        }

        // Перевантаження оператора "/" для ділення координат точок прямокутника на число
        public static Rectangle operator /(Rectangle r, double value)
        {
            return new Rectangle(
                new Point(r.GetPoint1().GetX() / value, r.GetPoint1().GetY() / value),
                new Point(r.GetPoint2().GetX() / value, r.GetPoint2().GetY() / value),
                new Point(r.GetPoint3().GetX() / value, r.GetPoint3().GetY() / value),
                new Point(r.GetPoint4().GetX() / value, r.GetPoint4().GetY() / value)
            );
        }

        // Перевантаження оператора "/" для ділення координат точок на координати іншого прямокутника
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(
                new Point(r1.GetPoint1().GetX() / r2.GetPoint1().GetX(), r1.GetPoint1().GetY() / r2.GetPoint1().GetY()),
                new Point(r1.GetPoint2().GetX() / r2.GetPoint2().GetX(), r1.GetPoint2().GetY() / r2.GetPoint2().GetY()),
                new Point(r1.GetPoint3().GetX() / r2.GetPoint3().GetX(), r1.GetPoint3().GetY() / r2.GetPoint3().GetY()),
                new Point(r1.GetPoint4().GetX() / r2.GetPoint4().GetX(), r1.GetPoint4().GetY() / r2.GetPoint4().GetY())
            );
        }
    }
}