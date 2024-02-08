using Microsoft.EntityFrameworkCore;
using NewSchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchoolDB.Data
{
    internal class SchoolDbContext : DbContext 
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeRole> EmployeesRole { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<GradingScale> GradesScale { get; set;}

        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = DESKTOP-53F8V9T;Initial Catalog = FinalProjectDB;Integrated Security=True;TrustServerCertificate=Yes;");
        }
    }
}
