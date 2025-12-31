//using ConsoleApp1/*.AutatiomTestResultManager.Services;
//using ConsoleApp1.AutomatiomTestResultManager.Interfaces;
//using ConsoleApp1.AutomatiomTestResultManager.Models;

//ITestResultService service = new TestResultService();

//service.Add(new TestResult(1, "Login Test", "Pass", 2.3));
//service.Add(new TestResult(2, "Checkout Test", "Fail", 1.8));

//foreach (var r in service.GetAll())
//{
//    Console.WriteLine($"{r.TestName} - {r.Status}");
//}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Create a collection
        List<string> students = new List<string>();

        // Step 2: Add elements
        students.Add("Srajana");
        students.Add("Rahul");
        students.Add("Anita");

        Console.WriteLine("Students after adding:");
        DisplayStudents(students);

        // Step 3: Remove an element
        students.Remove("Rahul");

        Console.WriteLine("\nStudents after removing Rahul:");
        DisplayStudents(students);

        // Step 4: Check if student exists
        if (students.Contains("Srajana"))
        {
            Console.WriteLine("\nSrajana is present in the list");
        }

        // Step 5: Count
        Console.WriteLine($"\nTotal students: {students.Count}");
    }

    static void DisplayStudents(List<string> students)
    {
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}

