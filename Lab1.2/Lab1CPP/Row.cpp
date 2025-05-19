#include "Row.h"
// Метод повертає константне посилання на вектор символів (_values)
const std::vector<char>& Row::getValues() const {
    return _values;
};

// Метод повертає кількість елементів у векторі
size_t Row::getLength() const {
    return _values.size();
};
// Метод видаляє перше входження символу '5' з вектора _values
void Row::removeFive() {
    for (int i = 0; i < _values.size(); i++)
    {
        if (_values[i] == '5')  // Якщо знайдено символ '5'
        {
            _values.erase(_values.begin() + i);  // Видаляється елемент
            break;  // Припинення циклу після першого видалення
        }
    }
}
