using Lab2_24.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 21 },
            new Student { Id = 2, Name = "Maria", Age = 19 },
            new Student { Id = 3, Name = "Vlad", Age = 22 },
            new Student { Id = 4, Name = "Florin", Age = 25 },
            new Student { Id = 5, Name = "Marian", Age = 20 },
        };


        [HttpGet("getAllOrdered")]
        public List<Student> GetAllOrdered()
        {
            return students.OrderByDescending(s => s.Name).ToList();
        }


        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }


        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }


        [HttpDelete("id")]
        public List<Student> Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            return students;
        }
    }
}
