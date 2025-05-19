using System;
namespace Lab3
{
    class Program
    {
        // Головний метод програми
        static void Main(string[] args)
        {
            // Створення прямокутника Q2 з чотирма заданими точками
            Rectangle Q2 = new Rectangle(
                p3: new Point(8, 3), 
                p4: new Point(8, 6), 
                p1: new Point(3, 3), 
                p2: new Point(3, 6)
            );

            // Створення копії прямокутника Q2
            Rectangle Q3 = new Rectangle(Q2);

            // Ділення координат точок Q2 на 2 (масштабування)
            Q2 /= 2;

            // Віднімання координат точок Q2 від Q3, створення нового прямокутника TR1
            Rectangle TR1 = new Rectangle(Q3 - Q2);

            // Виведення периметра TR1
            Console.WriteLine(TR1.GetPerimeter());

            // Виведення площі TR1
            Console.WriteLine(TR1.GetArea());
        }
    }
}