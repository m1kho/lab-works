#include "figure.h"

Figure::Figure() : x1(0), y1(0), x2(0), y2(0), x3(0), y3(0), x4(0), y4(0) {}
Figure::Figure(double a1, double b1, double a2, double b2, double a3, double b3, double a4, double b4)
    : x1(a1), y1(b1), x2(a2), y2(b2), x3(a3), y3(b3), x4(a4), y4(b4) {}
Figure::Figure(const Figure& other) = default;
Figure::~Figure() = default;

double Figure::getX1() const { return x1; }
double Figure::getY1() const { return y1; }