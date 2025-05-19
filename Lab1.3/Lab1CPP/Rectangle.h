#pragma once

#include <cmath>
#include <string>
#include <ostream>

#include "Point.h"

// Клас, що представляє прямокутник за координатами чотирьох точок
class Rectangle {
private:
    Point point1, point2, point3, point4;

public:
    // Конструктор за замовчуванням — усі точки (0,0)
    Rectangle() : point1(), point2(), point3(), point4() {}

    // Конструктор з параметрами — ініціалізація 4 точками
    Rectangle(const Point& p1, const Point& p2, const Point& p3, const Point& p4)
        : point1(p1), point2(p2), point3(p3), point4(p4) {}

    // Конструктор копіювання
    Rectangle(const Rectangle& other)
        : point1(other.point1), point2(other.point2), point3(other.point3), point4(other.point4) {}

    // Конструктор переміщення
    Rectangle(Rectangle&& other)
        : point1(std::move(other.point1)), point2(std::move(other.point2)),
          point3(std::move(other.point3)), point4(std::move(other.point4)) {}

    // Деструктор
    ~Rectangle() = default;

    // Гетери для точок
    const Point& getPoint1() const;
    const Point& getPoint2() const;
    const Point& getPoint3() const;
    const Point& getPoint4() const;

    // Обчислення периметра
    double getPerimeter() const;

    // Обчислення площі
    double getArea() const;

    // Оператори для арифметичних дій над координатами
    Rectangle operator-(double value) const;
    Rectangle operator-(const Rectangle& r) const;

    Rectangle operator/(double value) const;
    Rectangle operator/(const Rectangle& r) const;

    // Оператор копіювального присвоєння
    Rectangle& operator=(const Rectangle& other);
};

// Оператор виводу: виводить периметр і площу прямокутника
inline std::ostream& operator<<(std::ostream& out, const Rectangle& r) {
    out << r.getPerimeter() << " " << r.getArea();
    return out;
}
