#pragma once

#include <ostream>
#include <vector>

// Клас Row, який представляє ряд символів
class Row
{
private:
	// Приватне поле: вектор символів
	std::vector<char> _values;

public:
	// Конструктор за замовчуванням – створює порожній вектор
	Row() : _values() {}

	// Конструктор з параметром – ініціалізує _values переданим вектором символів

	Row(const std::vector<char>& values) : _values(values) {}

	// Конструктор переміщення – "переміщує" вміст з іншого об'єкта (використовує std::move)
	Row(Row&& anotherRow) : _values(std::move(anotherRow._values)) {}

	// Конструктор копіювання – створює копію з іншого об'єкта (використовує getValues())
	Row(const Row& other) : _values(other.getValues()) {}

	// Деструктор – за замовчуванням (нічого додатково не виконує)
	~Row() {}

	// Метод доступу до вектора символів
	const std::vector<char>& getValues() const;

	// Метод, який повертає кількість символів
	size_t getLength() const;

	size_t getSize() const;

	// Метод, що видаляє перше входження '5'
	void removeFive();
};
