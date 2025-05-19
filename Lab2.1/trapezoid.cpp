#include "trapezoid.h"
#include <cmath>

Trapezoid::Trapezoid() : Figure() {}
Trapezoid::Trapezoid(double a1, double b1, double a2, double b2,
                     double a3, double b3, double a4, double b4)
    : Figure(a1, b1, a2, b2, a3, b3, a4, b4) {}

Trapezoid::Trapezoid(const Trapezoid& other) : Figure(other) {}

double Trapezoid::distance(double x1, double y1, double x2, double y2) const {
    return std::sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
}

double Trapezoid::perimeter() const {
    return distance(x1, y1, x2, y2) + distance(x2, y2, x3, y3) +
           distance(x3, y3, x4, y4) + distance(x4, y4, x1, y1);
}

double Trapezoid::area() const {
    double base1 = distance(x1, y1, x2, y2);
    double base2 = distance(x3, y3, x4, y4);
    double height = std::abs(y1 - y3);
    return 0.5 * (base1 + base2) * height;
}
