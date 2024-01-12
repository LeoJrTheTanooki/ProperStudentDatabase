using StudentDatabase.Models;

namespace StudentDatabase.Services.Students;

public interface IStudentService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string firstName, string lastName, string hobbies);
    List<Student> DeleteStudent(string firstName);
    // List<Student> UpdateStudent(string oldName, string newName);
}