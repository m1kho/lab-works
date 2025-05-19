using System.Collections.Generic;
public class StudentTable
{
    private List<(string FirstName, string LastName, string MiddleName)> _students = new List<(string FirstName, string LastName, string MiddleName)>(); // List of students

    private int Lenth => _students.Count; // Number of students at beginning

    public (string FirstName, string LastName, string MiddleName) this[int index] // 
    {
        get
        {
            if (index < 0 || index >= _students.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
            return _students[index];
        }
        set
        {
            if (index >= 0 && index < _students.Count)
            {
                _students[index] = value;
            }
            else if (index == _students.Count)
            {
                _students.Add(value);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
            }
        }
    }
    public int StudentCount => _students.Count; // Number of students
}