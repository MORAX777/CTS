using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    // Aryan Kumar Raj - 231fa18066
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Aryan Kumar Raj", RollNo = "231fa18066", Course = "DotNet FSE Angular" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(_students);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> PostStudent(Student student)
        {
            student.Id = _students.Max(s => s.Id) + 1;
            _students.Add(student);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }
    }
}
