using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolProject_GD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject_GD.Repository
{
    public class SchoolDbContext : DbContext
    {

        public SchoolDbContext()
        {
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)  : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<StudentSubject> StudentSubjects { get; set; }        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("C:/Users/Gocha/source/repos/SchoolProject_GD/SchoolProject_GD/appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        }
    }
}
