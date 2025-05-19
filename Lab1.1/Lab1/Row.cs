// Оголошення класу Row
class Row
{
    // Публічне поле, що містить список символів
    public List<char> Values;

    // Конструктор, що приймає список символів і зберігає його у полі Values
    public Row(List<char> values)
    {
        Values = values;
    }

    // Метод, що повертає масив символів, створений з поля Values
    public char[] GetValues()
    {
        return Values.ToArray();
    }

    // Метод, що повертає кількість символів у списку
    public int GetLength()
    {
        return Values.Count;
    }

    // Метод, що видаляє ПЕРШЕ входження символу '5' із списку
    public void RemoveFive()
    {
        Values.Remove('5');  // Remove видаляє тільки перший знайдений елемент
    }
}

