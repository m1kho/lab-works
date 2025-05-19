#include "Row.h"

// Метод повертає константне посилання на вектор символів (_values)
const std::vector<char>& Row::getValues() const { return _values; };

// Метод повертає кількість символів у векторі (_values)
size_t Row::getLength() const { return _values.size(); };

// Метод видаляє ПЕРШЕ входження символу '5' із вектора
void Row::removeFive() {
    for (int i = 0; i < _values.size(); i++) {
        if (_values[i] == '5') {
            _values.erase(_values.begin() + i);  // Видаляємо елемент на позиції i
            break;  // Після видалення зупиняємо цикл
        }
    }
}

