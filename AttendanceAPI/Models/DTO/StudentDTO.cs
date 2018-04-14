using System.Collections.Generic;

namespace AttendanceAPI.Models.DTO
{
    public class StudentDTO
    {
        public int id { get; set; }
        public string RegistrationID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}