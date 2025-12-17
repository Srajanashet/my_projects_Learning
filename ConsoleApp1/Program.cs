using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main()
    {
        //Console.WriteLine("=== TASK MANAGER===");
        //Console.WriteLine("1. Add Task ");
        //Console.WriteLine("2.View Tasks");
        //Console.WriteLine("3.Exit");
        //Console.Write("choose an option: ");
        //string choice = Console.ReadLine();
        //Console.WriteLine("you chose: " + choice);
        List<string> Tasks = new List<string>();
        Console.WriteLine("Enter a Task");
        Tasks.Add(Console.ReadLine());
        Console.WriteLine("\nTask added:");
        foreach (string task in Tasks)
        {
            Console.WriteLine("-" + task);
        }
        Console.ReadKey();






        D
            
    }

}