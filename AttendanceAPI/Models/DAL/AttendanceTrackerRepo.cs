using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceAPI.Models;
using AttendanceAPI.Models.Banner;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

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
            Module module = await context.Modules.FindAsync(id);
            if (module == null)
            {
                return null;
            }
            context.Modules.Remove(module);
            await context.SaveChangesAsync();

            return module;
        }

        public async Task<Student> DeleteStudent(int id)
        {
            Student student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return null;
            }
            context.Students.Remove(student);
            await context.SaveChangesAsync();

            return student;
        }

        public async Task<Enrollment> Disenroll(int id)
        {
            Enrollment enrollment = await context.Enrollments.FindAsync(id);
            if (enrollment == null)
            {
                return null;
            }
            context.Enrollments.Remove(enrollment);
            await context.SaveChangesAsync();

            return enrollment;
        }

        public async Task<Enrollment> Enroll(Enrollment e)
        {
            context.Enrollments.Add(e);
            await context.SaveChangesAsync();
            return e;
        }

        public Attendance GetAttendance(int id)
        {
            Attendance a = context.Attendances.Find(id);
            if (a != null)
            {
                return a;
            }
            return null;
        }

        public async Task<IList<Delivery>> GetDeliveries()
        {
            return await context.Deliveries.ToListAsync();
        }

        public Delivery GetDelivery(int id)
        {
            Delivery d = context.Deliveries.Find(id);
            if (d != null)
            {
                return d;
            }
            return null;
        }

        public Lecturer GetLecturer(int id)
        {
            Lecturer l = context.Lecturers.Find(id);
            if (l != null)
            {
                return l;
            }
            return null;
        }

        public async Task<IList<Lecturer>> GetLecturers()
        {
            return await context.Lecturers.ToListAsync();
        }

        public Module GetModule(int id)
        {
            Module m = context.Modules.Find(id);
            if (m != null)
            {
                return m;
            }
            return null;
        }

        public async Task<IList<Module>> GetModules()
        {
            return await context.Modules.ToListAsync();
        }

        public Student GetStudent(int id)
        {
            Student s = context.Students.Find(id);
            if (s != null)
            {
                return s;
            }
            return null;
        }

        public StudentAttendance GetStudentAttendance(int id)
        {
            StudentAttendance s = context.AttendanceList.Find(id);
            if (s != null)
            {
                return s;
            }
            return null;
        }
        
        public async Task<IList<Student>> GetStudents()
        {
            return await context.Students.ToListAsync();
        }

        public async Task<Attendance> UpdateAttendance(Attendance a)
        {
            context.Entry(a).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return a;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendanceExists(a.id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool AttendanceExists(int id)
        {
            return context.Attendances.Count(a => a.id == id) > 0;
        }

        public async Task<Delivery> UpdateDelivery(Delivery d)
        {
            context.Entry(d).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return d;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(d.id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool DeliveryExists(int id)
        {
            return context.Deliveries.Count(a => a.id == id) > 0;
        }

        public async Task<Lecturer> UpdateLecturer(Lecturer l)
        {
            context.Entry(l).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return l;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(l.id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool LecturerExists(int id)
        {
            return context.Lecturers.Count(a => a.id == id) > 0;
        }

        public async Task<Module> UpdateModule(Module m)
        {
            context.Entry(m).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return m;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(m.id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool ModuleExists(int id)
        {
            return context.Modules.Count(a => a.id == id) > 0;
        }

        public async Task<Student> UpdateStudent(Student s)
        {
            context.Entry(s).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return s;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(s.id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool StudentExists(int id)
        {
            return context.Students.Count(a => a.id == id) > 0;
        }

        public async Task<StudentAttendance> UpdateStudentAttendance(StudentAttendance s)
        {
            context.Entry(s).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
                return s;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(s.id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool StudentAttendanceExists(int id)
        {
            return context.AttendanceList.Count(a => a.id == id) > 0;
        }
    }
}