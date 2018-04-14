using AttendanceAPI.Models;
using AttendanceAPI.Models.DTO;
using AutoMapper;

namespace AttendanceAPI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping Students
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();
        }
    }
}