using StudentDatabase.Models;
using StudentDatabase.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace StudentDatabase.Controllers;

[ApiController]
[Route("[controller]")]

public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService; 

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route("FetchQuest")]
    public List<Student> GetStudents()
    {
        return _studentService.GetStudents();
    }

    [HttpPost]
    [Route("AddStudent/{firstName}+{lastName}+{hobbies}")]
    public List<Student> AddStudent(string firstName, string lastName, string hobbies)
    {
        return _studentService.AddStudent(firstName, lastName, hobbies);
    }

    [HttpDelete]
    [Route("DeleteStudent/{firstName}")]
    public List<Student> DeleteStudent(string firstName)
    {
        return _studentService.DeleteStudent(firstName);
    }

    // [HttpPut]
    // [Route("EditStudent/{oldName}/{newName}")]
    // public List<Student> UpdateStudent(string oldName, string newName)
    // {
    //     return _studentService.UpdateStudent(oldName, newName);
    // }
}
