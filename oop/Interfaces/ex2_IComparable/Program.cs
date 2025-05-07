using System;
using System.Collections.Generic;

class Student : IComparable<Student>
{
    public string Name { get; set; }
    public double Grade { get; set; }

    public Student(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }

    public int CompareTo(Student other)
    {
        int gradeComparison = other.Grade.CompareTo(this.Grade); // Descending
        if (gradeComparison == 0)
        {
            return this.Name.CompareTo(other.Name); // Ascending
        }
        return gradeComparison;
    }

    public override string ToString()
    {
        return $"{Name}: {Grade}";
    }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student("Alice", 90.5),
            new Student("Bob", 90.5),
            new Student("Charlie", 85.3),
        };

        students.Sort();

        foreach (var student in students)
            Console.WriteLine(student);
    }
}