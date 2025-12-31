using System;

namespace ConsoleApp1.Models
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public CourseType Course { get; private set; }

        public Student(int id, string name, int age, CourseType course)
        {
            Id = id;
            Name = name;
            Age = age;
            Course = course;
        }

        public void UpdateDetails(string name, int age, CourseType course)
        {
            Name = name;
            Age = age;
            Course = course;
        }
    }
}
