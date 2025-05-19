#ifndef TRAPEZOID_H
#define TRAPEZOID_H

#include "figure.h"

class Trapezoid : public Figure {
public:
    Trapezoid();
    Trapezoid(double, double, double, double, double, double, double, double);
    Trapezoid(const Trapezoid& other);

    double area() const override;
    double perimeter() const override;

private:
    double distance(double x1, double y1, double x2, double y2) const;
};

#endif
