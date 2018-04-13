using System.Collections.Generic;

namespace AttendanceAPI.Models.DTO
{
    public class StudentDTO
    {
        public int id { get; set; }
        public string RegistrationID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; }

        public static class Builder
        {
            public static StudentDTO Build(Student student)
            {
                StudentDTO dto = new StudentDTO();
                dto.id = student.id;
                dto.RegistrationID = student.RegistrationID;
                dto.FirstName = student.FirstName;
                dto.SecondName = student.SecondName;

                return student;
            }
        }
    }
}