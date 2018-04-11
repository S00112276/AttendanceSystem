namespace AttendanceAPI.Migrations.ApplicationUserMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AttendanceAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationUserMigrations";
        }

        protected override void Seed(AttendanceAPI.Models.ApplicationDbContext context)
        {
        }
    }
}
