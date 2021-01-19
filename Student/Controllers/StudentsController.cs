using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student.Models;
using Student.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        // GET: api/Students
        [HttpGet]
        public IEnumerable<Stud> GetAllStud() => studentRepository.GetAllStud();
        


         // GET: api/Students/5
        [HttpGet("{StudId}")]
        public Stud GetStud(int StudId) => studentRepository.GetStud(StudId);


        // POST: api/Students
        [HttpPost]
        //public void AddStud([FromBody] Stud student) => studentRepository.Add(student);
        public ActionResult<Stud> PostStud(Stud stud)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Data");
            studentRepository.AddStud(stud);
            return Ok("Added Successfully.");
        }


        // PUT: api/Students/5
        [HttpPut("{StudId}")]
        public void Put(int StudId, [FromBody] Stud stud) => studentRepository.Update(stud);




        // DELETE: api/ApiWithActions/5
        [HttpDelete("{StudId}")]
        public void DeleteStud(int StudId) => studentRepository.Delete(StudId);


    }
}
