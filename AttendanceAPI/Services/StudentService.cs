using AttendanceAPI.DAL;
using AttendanceAPI.Models;
using AttendanceAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceAPI.Services
{
    public class StudentService
    {
        private AttendanceTrackerRepo attendanceTrackerRepo;
        public StudentDTO GetAllStudents()
        {
            StudentDTO studentDto = new StudentDTO();
            return studentDto;
        }

        public StudentDTO getStudentById(int id)
        {
            Student student;
            Student result = attendanceTrackerRepo.GetStudent(id);

            StudentDTO dto = null;

            if(result != null)
            {
                student = result;
                return StudentDTO.Builder.Build(student);
            }

            return dto;
        }
    }
}