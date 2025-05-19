#ifndef FIGURE_H
#define FIGURE_H

class Figure {
protected:
    double x1, y1, x2, y2, x3, y3, x4, y4;

public:
    Figure();
    Figure(double, double, double, double, double, double, double, double);
    Figure(const Figure& other);
    virtual ~Figure();

    double getX1() const;
    double getY1() const;

    virtual double area() const = 0;
    virtual double perimeter() const = 0;
};

#endif

