using System.Text.Json;

public static class FileStorage
{
    private static readonly string filePath = "students.json";

    public static void Save(List<Student> students)
    {
        string json = JsonSerializer.Serialize(students, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(filePath, json);
    }

    public static List<Student> Load()
    {
        if (!File.Exists(filePath))
            return new List<Student>();

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
    }
}

