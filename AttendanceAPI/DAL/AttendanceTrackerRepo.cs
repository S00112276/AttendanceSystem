using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AttendanceAPI.Models;
using AttendanceAPI.Models.Banner;

namespace AttendanceAPI.DAL
{
    public class AttendanceTrackerRepo : IAttendanceTracker
    {
        private AttendanceDB context;

        public AttendanceTrackerRepo(AttendanceDB context)
        {
            this.context = context;
        }

        public async Task<Attendance> AddAttendance(Attendance a)
        {
            context.Attendances.Add(a);
            await context.SaveChangesAsync();
            return a;
        }

        public async Task<Delivery> AddDelivery(Delivery d)
        {
            context.Deliveries.Add(d);
            await context.SaveChangesAsync();
            return d;
        }

        public async Task<Lecturer> AddLecturer(Lecturer l)
        {
            context.Lecturers.Add(l);
            await context.SaveChangesAsync();
            return l;
        }

        public async Task<Module> AddModule(Module m)
        {
            context.Modules.Add(m);
            await context.SaveChangesAsync();
            return m;
        }

        public async Task<Student> AddStudent(Student s)
        {
            context.Students.Add(s);
            await context.SaveChangesAsync();
            return s;
        }

        public async Task<StudentAttendance> AddStudentAttendance(StudentAttendance s)
        {
            context.AttendanceList.Add(s);
            await context.SaveChangesAsync();
            return s;
        }

        public async Task<Delivery> DeleteDelivery(int id)
        {
            Delivery delivery = await context.Deliveries.FindAsync(id);
            if (delivery == null)
            {
                return null;
            }
            context.Deliveries.Remove(delivery);
            await context.SaveChangesAsync();

            return delivery;
        }

        public async Task<Lecturer> Deletelecturer(int id)
        {
            Lecturer lecturer = await context.Lecturers.FindAsync(id);
            if (lecturer == null)
            {
                return null;
            }
            context.Lecturers.Remove(lecturer);
            await context.SaveChangesAsync();

            return lecturer;
        }

        public async Task<Module> DeleteModule(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Enrollment Disenroll(int id)
        {
            throw new NotImplementedException();
        }

        public async Enrollment Enroll(Enrollment e)
        {
            throw new NotImplementedException();
        }

        public async Attendance GetAttendance(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Delivery>> GetDeliveries()
        {
            throw new NotImplementedException();
        }

        public async Delivery GetDelivery(int id)
        {
            throw new NotImplementedException();
        }

        public async Lecturer GetLecturer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Lecturer>> GetLecturers()
        {
            throw new NotImplementedException();
        }

        public async Module GetModule(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Module>> GetModules()
        {
            throw new NotImplementedException();
        }

        public async Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async StudentAttendance GetStudentAttendance(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<Attendance> UpdateAttendance(Attendance a)
        {
            throw new NotImplementedException();
        }

        public Task<Delivery> UpdateDelivery(Delivery d)
        {
            throw new NotImplementedException();
        }

        public Task<Lecturer> UpdateLecturer(Lecturer l)
        {
            throw new NotImplementedException();
        }

        public Task<Module> UpdateModule(Module m)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public Task<StudentAttendance> UpdateStudentAttendance(StudentAttendance s)
        {
            throw new NotImplementedException();
        }
    }
}