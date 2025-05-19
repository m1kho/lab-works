#pragma once

#include <cmath>
#include <ostream>

// Клас, що представляє точку у 2D-просторі
class Point {
private:
    double x, y; // Координати точки

public:
    // Конструктор з параметрами, за замовчуванням створює точку (0,0)
    Point(double x = 0, double y = 0) : x(x), y(y) {}

    // Конструктор копіювання
    Point(const Point& other) : x(other.x), y(other.y) {}

    // Конструктор переміщення
    Point(Point&& other) : x(std::move(other.x)), y(std::move(other.y)) {}

    // Деструктор
    ~Point() {}

    // Гетери координат
    double getX() const;
    double getY() const;

    // Оператор копіювального присвоєння
    Point& operator=(const Point& other);
};

// Функція, що обчислює відстань між двома точками
inline double getLength(const Point& p1, const Point& p2) {
    return std::sqrt(std::pow(p2.getX() - p1.getX(), 2) + std::pow(p2.getY() - p1.getY(), 2));
}

// Оператор виводу для об'єкта Point
inline std::ostream& operator<<(std::ostream& os, const Point& p) {
    os << "(" << p.getX() << "; " << p.getY() << ")";
    return os;
}