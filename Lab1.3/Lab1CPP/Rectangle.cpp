#include "Rectangle.h"

const Point& Rectangle::getPoint1() const { return point1; }
const Point& Rectangle::getPoint2() const { return point2; }
const Point& Rectangle::getPoint3() const { return point3; }
const Point& Rectangle::getPoint4() const { return point4; }

double Rectangle::getPerimeter() const {
    double width = getLength(point1, point2);
    double height = getLength(point1, point4);
    return 2 * (width + height);
}

double Rectangle::getArea() const {
    double width = getLength(point1, point2);
    double height = getLength(point1, point4);
    return width * height;
}

Rectangle Rectangle::operator-(double value) const {
    return Rectangle(
        { point1.getX() - value, point1.getY() - value },
        { point2.getX() - value, point2.getY() - value },
        { point3.getX() - value, point3.getY() - value },
        { point4.getX() - value, point4.getY() - value }
    );
}

Rectangle Rectangle::operator-(const Rectangle& r) const {
    return Rectangle(
        { point1.getX() - r.point1.getX(), point1.getY() - r.point1.getY() },
        { point2.getX() - r.point2.getX(), point2.getY() - r.point2.getY() },
        { point3.getX() - r.point3.getX(), point3.getY() - r.point3.getY() },
        { point4.getX() - r.point4.getX(), point4.getY() - r.point4.getY() }
    );
}

Rectangle Rectangle::operator/(double value) const {
    return Rectangle(
        { point1.getX() / value, point1.getY() / value },
        { point2.getX() / value, point2.getY() / value },
        { point3.getX() / value, point3.getY() / value },
        { point4.getX() / value, point4.getY() / value }
    );
}

Rectangle Rectangle::operator/(const Rectangle& r) const {
    return Rectangle(
        { point1.getX() / r.point1.getX(), point1.getY() / r.point1.getY() },
        { point2.getX() / r.point2.getX(), point2.getY() / r.point2.getY() },
        { point3.getX() / r.point3.getX(), point3.getY() / r.point3.getY() },
        { point4.getX() / r.point4.getX(), point4.getY() / r.point4.getY() }
    );
}

Rectangle& Rectangle::operator=(const Rectangle& other) {
    point1 = other.point1;
    point2 = other.point2;
    point3 = other.point3;
    point4 = other.point4;
    return *this;
}
