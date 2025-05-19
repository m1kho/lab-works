#include "Point.h"

// Гетер для координати X
double Point::getX() const {
	return x;
}

// Гетер для координати Y
double Point::getY() const {
	return y;
}

// Оператор копіювального присвоєння
Point& Point::operator=(const Point& other) {
	x = other.x;
	y = other.y;
	return *this; // Повертає посилання на поточний об’єкт
}