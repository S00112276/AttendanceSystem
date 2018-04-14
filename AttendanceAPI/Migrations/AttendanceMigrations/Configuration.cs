namespace AttendanceAPI.Migrations.AttendanceMigrations
{
    using CsvHelper;
    using Models;
    using Models.Banner;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<AttendanceAPI.Models.Banner.AttendanceDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\AttendanceMigrations";
        }

        protected override void Seed(AttendanceAPI.Models.Banner.AttendanceDB context)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();

            //// Students
            //string resourceName = "AttendanceAPI.Migrations.AttendanceMigrations.Students.csv";
            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //{
            //    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            //    {
            //        CsvReader csvReader = new CsvReader(reader);
            //        csvReader.Configuration.HasHeaderRecord = false;
            //        var students = csvReader.GetRecords<Student>().ToArray();
            //        context.Students.AddOrUpdate(s => s.id, students);
            //    }
            //}
            //context.SaveChanges();

            ////Students
            //context.Students.AddOrUpdate(s => s.RegistrationID,
            //    new Student[]
            //    {
            //        new Student { RegistrationID = "S00853062",  FirstName = "Sosanna", SecondName =  "Gosby", Email = "sgosby0@diigo.com", PhoneNumber = "(301) 6767960", EnrolledFor = new List<Enrollment>() },
            //        new Student { RegistrationID = "S00377910", FirstName = "Magda", SecondName = "Rudram", Email = "mrudram1@npr.org", PhoneNumber = "(696) 1324233", EnrolledFor = new List<Enrollment>() },
            //        new Student { RegistrationID = "S00304088", FirstName = "Norby", SecondName = "Huntingdon", Email = "nhuntingdon2@webeden.co.uk", PhoneNumber = "(617) 1912073", EnrolledFor = new List<Enrollment>() },
            //        new Student { RegistrationID = "S00160641", FirstName = "Sophia", SecondName = "Price", Email = "S00160641@mail.itsligo.ie", PhoneNumber = "(353) 2693633", EnrolledFor = new List<Enrollment>() },
            //        new Student { RegistrationID = "S00123456", FirstName = "Norby", SecondName = "Ellis", Email = "nEllis@mail.ie", PhoneNumber = "(303) 1234567", EnrolledFor = new List<Enrollment>() },
            //        new Student { RegistrationID = "S00123457", FirstName = "Cole", SecondName = "Gosby", Email = "cole@mail.ie", PhoneNumber = "(300) 1234568", EnrolledFor = new List<Enrollment>() }
            //    });
            //context.SaveChanges();

            // Students
            Student s1 = new Student { RegistrationID = "S00853062", FirstName = "Sosanna", SecondName = "Gosby", Email = "sgosby0@diigo.com", PhoneNumber = "(301) 6767960", EnrolledFor = new List<Enrollment>() };
            Student s2 = new Student { RegistrationID = "S00377910", FirstName = "Magda", SecondName = "Rudram", Email = "mrudram1@npr.org", PhoneNumber = "(696) 1324233", EnrolledFor = new List<Enrollment>() };
            Student s3 = new Student { RegistrationID = "S00304088", FirstName = "Norby", SecondName = "Huntingdon", Email = "nhuntingdon2@webeden.co.uk", PhoneNumber = "(617) 1912073", EnrolledFor = new List<Enrollment>() };
            Student s4 = new Student { RegistrationID = "S00160641", FirstName = "Sophia", SecondName = "Price", Email = "S00160641@mail.itsligo.ie", PhoneNumber = "(353) 2693633", EnrolledFor = new List<Enrollment>() };
            Student s5 = new Student { RegistrationID = "S00123456", FirstName = "Norby", SecondName = "Ellis", Email = "nEllis@mail.ie", PhoneNumber = "(303) 1234567", EnrolledFor = new List<Enrollment>() };
            Student s6 = new Student { RegistrationID = "S00123457", FirstName = "Cole", SecondName = "Gosby", Email = "cole@mail.ie", PhoneNumber = "(300) 1234568", EnrolledFor = new List<Enrollment>() };

            context.Students.Add(s1);
            context.Students.Add(s2);
            context.Students.Add(s3);
            context.Students.Add(s4);
            context.Students.Add(s5);
            context.Students.Add(s6);
            //context.SaveChanges();

            //// Modules
            //context.Modules.AddOrUpdate(m => m.id,
            //    new Models.Module[]
            //    {
            //        new Models.Module { ModuleName = "Rad302", Description = "bla bla bla" },
            //        new Models.Module { ModuleName = "PRJ300", Description = "important learning outcome" },
            //        new Models.Module { ModuleName = "Database", Description = "Vital information" }
            //    });

            // Modules
            Models.Module m1 = new Models.Module { ModuleName = "Rad302", Description = "bla bla bla" };
            Models.Module m2 = new Models.Module { ModuleName = "PRJ300", Description = "important learning outcome" };
            Models.Module m3 = new Models.Module { ModuleName = "Database", Description = "Vital information" };

            context.Modules.Add(m1);
            context.Modules.Add(m2);
            context.Modules.Add(m3);
            //context.SaveChanges();

            // Lecturers
            context.Lecturers.AddOrUpdate(l => l.id,
                new Lecturer[]
                {
                    new Lecturer { FirstName = "Paul", SecondName = "Powell" },
                    new Lecturer { FirstName = "Shane", SecondName = "Banks" },
                    new Lecturer { FirstName = "Vivion", SecondName = "Kinsella" },
                    new Lecturer { FirstName = "Keith", SecondName = "McManus" },
                    new Lecturer { FirstName = "Padraig", SecondName = "Harte" }
                });

            // Enrollments
            context.Enrollments.AddOrUpdate(e => e.id,
                new Enrollment[]
                {
                    new Enrollment { StudentId = s1.id, ModuleId = m1.id, EnrollmentDate = DateTime.Now, StudentEnrolled = s1, EnrolledOn = m1 }
                });
            context.SaveChanges();

            //// Enrollments
            //Enrollment s1e1 = new Enrollment { StudentId = s1.id, ModuleId = m1.id, EnrollmentDate = DateTime.Now };
            //Enrollment s1e2 = new Enrollment { StudentId = s1.id, ModuleId = m2.id, EnrollmentDate = DateTime.Now };
            //Enrollment s2e1 = new Enrollment { StudentId = s2.id, ModuleId = m3.id, EnrollmentDate = DateTime.Now };
            //Enrollment s2e2 = new Enrollment { StudentId = s2.id, ModuleId = m1.id, EnrollmentDate = DateTime.Now };
            //Enrollment s3e1 = new Enrollment { StudentId = s3.id, ModuleId = m2.id, EnrollmentDate = DateTime.Now };
            //Enrollment s3e2 = new Enrollment { StudentId = s3.id, ModuleId = m3.id, EnrollmentDate = DateTime.Now };

            //// Module Enrollments
            //m1.Enrollements.Add(s1e1);
            //m1.Enrollements.Add(s2e2);
            //m2.Enrollements.Add(s1e2);
            //m2.Enrollements.Add(s3e1);
            //m3.Enrollements.Add(s2e1);
            //m3.Enrollements.Add(s3e2);
        }

        // Get Random Student
        private int GetRandomStudentId(AttendanceDB Context)
        {
            return Context.Students.Select(s => new { s.id, order = Guid.NewGuid() })
                                    .OrderBy(o => o.order)
                                    .Select(s => s.id)
                                    .First();
        }

        // Get Random Module
        private int GetRandomModuleId(AttendanceDB Context)
        {
            return Context.Modules.Select(s => new { s.id, order = Guid.NewGuid() })
                                    .OrderBy(o => o.order)
                                    .Select(s => s.id)
                                    .First();
        }

    } 
}
