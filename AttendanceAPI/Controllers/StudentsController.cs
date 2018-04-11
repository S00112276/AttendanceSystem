using AttendanceAPI.DAL;
using AttendanceAPI.Models;
using AttendanceAPI.Models.Banner;
using AttendanceAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AttendanceAPI.Controllers
{
    //[Authorize(Roles = "Lecturer")]
    //[RoutePrefix("api/attendance")]
    public class StudentsController : ApiController
    {
        private AttendanceDB db = new AttendanceDB();

        private AttendanceTrackerRepo context;

        public StudentsController()
        {
            context = new AttendanceTrackerRepo(new AttendanceDB());
        }

        // For Injection
        public StudentsController(AttendanceTrackerRepo ctx)
        {
            context = ctx;
        }
        
        [HttpGet]
        [Route("Students")]
        public async Task<IList<Student>> GetStudents()
        {
            return await (context as AttendanceTrackerRepo).GetStudents();
        }

        [HttpGet]
        [Route("Student/{id:int}")]
        public async Task<IList<Student>> GetStudent(int id)
        {
            Student student = (context as AttendanceTrackerRepo).GetStudent(id);

            if(student != null)
            {
                StudentDTO studentDTO;
                //var enrollments = (context as AttendanceTrackerRepo).
            }

            return null;
        }
    }
}