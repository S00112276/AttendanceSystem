using AttendanceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AttendanceAPI.DAL
{
    public interface IAttendanceTracker
    {
        // Get users, modules and deliveries
        Task<IList<Student>> GetStudents();
        Task<IList<Lecturer>> GetLecturers();
        Task<IList<Module>> GetModules();
        Task<IList<Delivery>> GetDeliveries();
    }
}