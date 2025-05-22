using System;
using System.Collections.Generic;
public class ExampleTable
{
    public static void Main()
    {
        StudentTable students = new StudentTable();
        students[0] = ("John", "Doe", "A");
        students[1] = ("Jane", "Smith", "B");
        students[2] = ("Alice", "Johnson", "C");

        students[1] = ("Johnson", "Alice", "D");

        Console.WriteLine($"Студент за індексом 0: {students[0]}");
        Console.WriteLine($"Студент за індексом 1: {students[1]}");
        Console.WriteLine($"Студент за індексом 2: {students[2]}");
        
        Console.WriteLine($"Кількість студентів: {students.StudentCount}");
    }
}