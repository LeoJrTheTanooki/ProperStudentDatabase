using StudentDatabase.Data;
using StudentDatabase.Models;

namespace StudentDatabase.Services.Students;

public class StudentService : IStudentService
{
    private readonly DataContext _db;

    public StudentService(DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string firstName, string lastName, string hobbies)
    {
        Student newStudent = new();
        newStudent.FirstName = firstName;
        newStudent.LastName = lastName;
        newStudent.Hobbies = hobbies;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string firstName)
    {
        var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == firstName);
        if (student != null)
        {
            _db.Students.Remove(student);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }

    // public List<Student> UpdateStudent(string oldName, string newName)
    // {
    //     var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == oldName);
    //     if (student != null)
    //     {
    //         student.FirstName = newName;
    //         _db.SaveChanges();
    //     }
    //     return _db.Students.ToList();
    // }
}