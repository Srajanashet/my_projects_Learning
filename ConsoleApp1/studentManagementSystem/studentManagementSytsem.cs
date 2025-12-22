using System;
using System.Collections.Generic;
class Pro
{
    static List<Student> Students = new List<Student>();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Students Managment System");
        ShowMenu();
    }
    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n --- Menu ---");
            Console.WriteLine("1.Add Students");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Students");
            Console.WriteLine("4. Update Students");
            Console.WriteLine("5. Delete Students");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your Choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: ViewStudent(); break;
                case 3: SearchStudent(); break;
                case 4: UpdateStudent(); break;
                case 5: DeleteStudent(); break;
                case 6: return;
                default: Console.WriteLine("Invalid Choice"); break;

            }
        }
    }
    static void AddStudent()
    {
        Student s= new Student();
        Console.Write("Enter ID: ");
        s.ID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name:");
        s.Name = Console.ReadLine();
        Console.Write("Enter Age:");
        s.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Course: ");
        s.Course = Console.ReadLine();
        Students.Add(s);
        Console.WriteLine("Students Added Successfully!");

    }
    static void ViewStudent()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("No Student found.");
            return;
        }
        foreach (var s in Students)
        {
            Console.WriteLine($"ID: {s.ID}, Name:{s.Name}, Age: {s.Age}, Course: {s.Course}");

        }
    }
    static void SearchStudent()
    {
        Console.Write("Enter Id to Search:");
        int id = Convert.ToInt32(Console.ReadLine());
        var student= Students.Find(s=> s.ID== id);
        if (student != null)
            Console.WriteLine($"Found: {student.Name}, {student.Age}, {student.Course}");
        else
            Console.WriteLine("Studnet not found");
    }
    static void UpdateStudent()
    {
        Console.Write("Enter ID to Update:");
        int id = Convert.ToInt32(Console.ReadLine());
        var Student = Students.Find(s => s.ID== id);
        if (Student == null)
        {
            Console.WriteLine("Student not found");
            return;
        }
        Console.WriteLine("New Name:");
        Student.Name = Console.ReadLine();
        Console.Write("New Age:");
        Student.Age= Convert.ToInt32(Console.ReadLine());
        Console.Write("New Course:");
        Student.Course = Console.ReadLine();
        Console.WriteLine("Students Updated Successfully!");
    }
    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete:");
        int id = Convert.ToInt32(Console.ReadLine());
        var Student = Students.Find(s => s.ID == id);
        if (Student != null)
        {
            Students.Remove(Student);
            Console.WriteLine("Student deleted");
        }
        else
        {
            Console.WriteLine("Student not found");
        }

    }

}

