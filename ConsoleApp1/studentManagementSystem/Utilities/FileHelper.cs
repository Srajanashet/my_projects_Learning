using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ConsoleApp1.Models;

namespace ConsoleApp1.Utilities
{
    public static class FileHelper
    {
        private static readonly string path = "students.json";

        public static List<Student> Load()
        {
            if (!File.Exists(path))
                return new List<Student>();

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<Student>>(json)
                   ?? new List<Student>();
        }

        public static void Save(List<Student> students)
        {
            string json = JsonSerializer.Serialize(
                students,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(path, json);
        }
    }
}
