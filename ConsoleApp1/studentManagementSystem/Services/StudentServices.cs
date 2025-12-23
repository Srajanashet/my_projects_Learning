using ConsoleApp1.Models;
using ConsoleApp1.Exceptions;

namespace ConsoleApp1.Services
{
    public class StudentService
    {
        public void ValidateStudent(Student student)
        {
            if (student.Age < 18 && student.Course == CourseType.AI_ML)
                throw new InvalidStudentException(
                    "AI/ML course requires minimum age of 18"
                );
        }
    }
}
