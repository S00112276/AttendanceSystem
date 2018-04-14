namespace AttendanceAPI.Migrations.AttendanceMigrations
{
    using CsvHelper;
    using Models;
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

            // Students
            context.Students.AddOrUpdate(s => s.RegistrationID,
                new Student[]
                {
                    new Student { RegistrationID = "S00853062",  FirstName = "Sosanna", SecondName =  "Gosby", Email = "sgosby0@diigo.com", PhoneNumber = "(301) 6767960" },
                    new Student { RegistrationID = "S00377910", FirstName = "Magda", SecondName = "Rudram", Email = "mrudram1@npr.org", PhoneNumber = "(696) 1324233" },
                    new Student { RegistrationID = "S00304088", FirstName = "Norby", SecondName = "Huntingdon", Email = "nhuntingdon2@webeden.co.uk", PhoneNumber = "(617) 1912073" },
                    new Student { RegistrationID = "S00160641", FirstName = "Sophia", SecondName = "Price", Email = "S00160641@mail.itsligo.ie", PhoneNumber = "(353) 2693633" },
                    new Student { RegistrationID = "S00123456", FirstName = "Norby", SecondName = "Ellis", Email = "nEllis@mail.ie", PhoneNumber = "(303) 1234567" },
                    new Student { RegistrationID = "S00123457", FirstName = "Cole", SecondName = "Gosby", Email = "cole@mail.ie", PhoneNumber = "(300) 1234568" }
                });
            context.SaveChanges();

            // Modules
            context.Modules.AddOrUpdate(m => m.id,
                new Models.Module[]
                {
                    new Models.Module { ModuleName = "Rad302", Description = "bla bla bla" },
                    new Models.Module { ModuleName = "PRJ300", Description = "important learning outcome" },
                    new Models.Module { ModuleName = "Database", Description = "Vital information" }
                });

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

                });
        }
    } 
}
