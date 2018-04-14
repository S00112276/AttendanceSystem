using AttendanceAPI.Models;
using AttendanceAPI.Models.Banner;
using AttendanceAPI.Models.DTO;
using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;

namespace AttendanceAPI.Controllers
{
    //[Authorize(Roles = "Lecturer")]
    //[RoutePrefix("api/attendance")]
    public class StudentsController : ApiController
    {
        private AttendanceDB _attendanceDb;

        public StudentsController()
        {
            _attendanceDb = new AttendanceDB();
        }

        // GET /Students
        [HttpGet]
        [Route("Students")]
        public IHttpActionResult GetAllStudents()
        {
            var studentQuery = _attendanceDb.Students;

            var studentDto = studentQuery
                .ToList()
                .Select(Mapper.Map<Student, StudentDTO>);

            return Ok(studentDto);
        }

        // GET /Student/id
        [HttpGet]
        [Route("Student/{id}")]
        public IHttpActionResult GetStudentById(int id)
        {
            var student = _attendanceDb.Students.SingleOrDefault(s => s.id == id);

            if(student == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Student, StudentDTO>(student));
        }

        // Get /Student/name
        [HttpGet]
        [Route("Students/{fName}")] // Not Working?
        public IHttpActionResult GetStudentByFName(string fName)
        {
            var studentQuery = _attendanceDb.Students;

            var studentDto = studentQuery
                .ToList()
                .Where(s => s.FirstName == fName)
                .Select(Mapper.Map<Student, StudentDTO>);

            return Ok(studentDto);
        }

        // POST /Student
        [HttpPost]
        [Route("Student")]
        public IHttpActionResult CreateStudent(StudentDTO studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var student = Mapper.Map<StudentDTO, Student>(studentDto);
            _attendanceDb.Students.Add(student);
            _attendanceDb.SaveChanges();

            studentDto.id = student.id;

            return Created(new Uri(Request.RequestUri + "/" + student.id), studentDto);
        }

        // PUT /Student
        [HttpPut]
        [Route("Student/{id}")]
        public IHttpActionResult UpdateStudent(int id, StudentDTO studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = _attendanceDb.Students.SingleOrDefault(s => s.id == id);

            if (studentInDb == null)
                return NotFound();

            Mapper.Map(studentDto, studentInDb);

            _attendanceDb.SaveChanges();

            return Ok();
        }

        // DELETE /Student
        [HttpDelete]
        [Route("Student/{id}")]
        public IHttpActionResult DeleteStudent(int id)
        {
            var studentInDb = _attendanceDb.Students.SingleOrDefault(s => s.id == id);

            if (studentInDb == null)
                return NotFound();

            _attendanceDb.Students.Remove(studentInDb);
            _attendanceDb.SaveChanges();

            return Ok();
        }
    }
}