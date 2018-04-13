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
            context.Students.AddOrUpdate(s => s.FirstName,
                new Student[]
                {
                    new Student { RegistrationID = "S00853062",  FirstName = "Sosanna", SecondName =  "Gosby", Email = "sgosby0@diigo.com", PhoneNumber = "(301) 6767960" },
                    new Student { RegistrationID = "S00377910", FirstName = "Magda", SecondName = "Rudram", Email = "mrudram1@npr.org", PhoneNumber = "(696) 1324233" },
                    new Student { RegistrationID = "S00304088", FirstName = "Norby", SecondName = "Huntingdon", Email = "nhuntingdon2@webeden.co.uk", PhoneNumber = "(617) 1912073" }
                });
            context.SaveChanges();

            // Modules


            // Enrollments

        }
    } 
}
