﻿// Створення об'єкта класу Row з ініціалізацією списком символів {'1', '3', '5', '2', '4'}
Row row = new Row(new List<char>() { '1', '3', '5', '2', '4' });

// Виводиться кількість символів у списку
Console.WriteLine(row.GetLength());

// Виводиться список символів (перетворений на масив)
Console.WriteLine(row.GetValues());

// Видаляється перше входження символу '5' зі списку
row.RemoveFive();

// Знову виводиться оновлений список символів
Console.WriteLine(row.GetValues());

