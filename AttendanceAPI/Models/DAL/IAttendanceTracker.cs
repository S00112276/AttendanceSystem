using AttendanceAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AttendanceAPI.DAL
{
    public interface IAttendanceTracker
    {
        // Enrollment
        Task<Enrollment> Disenroll(int id);
        Task<Enrollment> Enroll(Enrollment e);

        // Students
        Task<IList<Student>> GetStudents();
        Task<Student> AddStudent(Student s);
        Task<Student> UpdateStudent(Student s);
        Task<Student> DeleteStudent(int id);
        Student GetStudent(int id);

        // Lecturers
        Task<IList<Lecturer>> GetLecturers();
        Task<Lecturer> AddLecturer(Lecturer l);
        Task<Lecturer> UpdateLecturer(Lecturer l);
        Task<Lecturer> Deletelecturer(int id);
        Lecturer GetLecturer(int id);

        // Module
        Task<IList<Module>> GetModules();
        Task<Module> AddModule(Module m);
        Task<Module> UpdateModule(Module m);
        Task<Module> DeleteModule(int id);
        Module GetModule(int id);

        // Deliveries
        Task<IList<Delivery>> GetDeliveries();
        Task<Delivery> AddDelivery(Delivery d);
        Task<Delivery> UpdateDelivery(Delivery d);
        Task<Delivery> DeleteDelivery(int id);
        Delivery GetDelivery(int id);

        // Attendance
        Task<Attendance> AddAttendance(Attendance a);
        Task<Attendance> UpdateAttendance(Attendance a);
        Attendance GetAttendance(int id);

        // StudentAttendance
        Task<StudentAttendance> AddStudentAttendance(StudentAttendance s);
        Task<StudentAttendance> UpdateStudentAttendance(StudentAttendance s);
        StudentAttendance GetStudentAttendance(int id);
    }
}