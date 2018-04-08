using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AttendanceAPI.Models.Banner
{
    public class AttendanceDB : DbContext
    {
        public AttendanceDB() : base("SchoolDB")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<StudentAttendance> AttendanceList { get; set; }
    }
}