using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{

    IStudentRepository studentRepository;
    ILogBook logBook;

    public StudentController(IStudentRepository student, ILogBook log)
    {
        studentRepository=student;
        logBook= log;
        
    }


    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logBook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logBook.Add($"The Student {student.Fullname} have been added");
    }
}
