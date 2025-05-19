using System;

class Row
{
    // Публічне поле: список символів
    public List<char> Values;

    // Конструктор за замовчуванням — створює порожній список
    public Row()
    {
        Values = new List<char>();
    }

    // Конструктор з параметром — приймає список символів і зберігає його
    public Row(List<char> values)
    {
        Values = values;
    }

    // Конструктор переміщення — приймає об'єкт Row за посиланням (ref) і "переміщує" значення
    public Row(ref Row anotherRow)
    {
        Values = anotherRow.Values;  // Копіює посилання на список символів
        anotherRow = null;           // Занулює переданий об'єкт (імітація переміщення)
    }

    // Конструктор копіювання — копіює посилання на список з іншого об'єкта Row
    public Row(Row other)
    {
        Values = other.Values;  // Це поверхневе копіювання (shallow copy)
    }

    // Деструктор — викликається при знищенні об'єкта (час виклику не гарантується)
    ~Row()
    {
        Console.WriteLine("Destructor called");
    }

    // Метод, що повертає значення списку у вигляді масиву символів
    public char[] GetValues()
    {
        return Values.ToArray();
    }

    // Метод, що повертає довжину списку символів
    public int GetLength()
    {
        return Values.Count;
    }

    // Метод, що видаляє перше входження символу '5' зі списку
    public void RemoveFive()
    {
        Values.Remove('5');  // Видаляє лише перше входження значення '5'
    }
}