// Запобігання багаторазовому включенню заголовку
#pragma once

#include <ostream>
#include <vector>

// Оголошення класу Row
class Row
{
private:
	std::vector<char> _values;  // Приватне поле – вектор символів

public:
	// Конструктор, який приймає вектор символів і копіює його у _values
	Row(const std::vector<char>& values) : _values(values) {}

	// Метод, що повертає вектор символів (константне посилання)
	const std::vector<char>& getValues() const;

	// Метод, що повертає кількість символів у векторі
	size_t getLength() const;

	// Метод для видалення символу '5' (першого входження)
	void removeFive();
};

// Перевантаження оператора << для виводу об'єкта Row у потік
inline std::ostream& operator<<(std::ostream& out, const Row& row) {
	for (int i = 0; i < row.getLength(); i++)
		out << row.getValues()[i];  // Виводимо кожен символ

	return out;
}

