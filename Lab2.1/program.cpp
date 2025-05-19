#include <iostream>
#include "trapezoid.h"

int main() {
    Trapezoid trap(0, 0, 4, 0, 3, 3, 1, 3);

    std::cout << "Perimeter: " << trap.perimeter() << std::endl;
    std::cout << "Area: " << trap.area() << std::endl;

    return 0;
}