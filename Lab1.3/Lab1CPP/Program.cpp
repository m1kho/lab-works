#include <iostream>
#include "Rectangle.h"

int main() {
	// Створюємо прямокутник Q2 з чотирьох точок
	Rectangle Q2(Point(3, 3), Point(3, 6), Point(8, 3), Point(8, 6));

	// Копіюємо Q2 у Q3
	Rectangle Q3(Q2);

	// Ділимо координати кожної вершини Q2 на 2 (масштабування)
	Q2 = Q2 / 2;

	// Створюємо новий прямокутник Q1 як результат віднімання Q2 від Q3
	Rectangle Q1(Q3 - Q2);

	// Виводимо периметр і площу Q1
	std::cout << Q1;

	return 0;
}