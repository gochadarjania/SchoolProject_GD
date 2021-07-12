using SchoolProject_GD.Domain;
using SchoolProject_GD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD.Repository
{
    public class StudentRepository : IStudentRepository
    {
        protected SchoolDbContext _context;
        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            Save();

        }
        public void RemoveStudent(int personalId) 
        {
            Student st = _context.Students.FirstOrDefault(x => x.StudentPersonalId == personalId);
            _context.Students.Remove(st);
            Save();

        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
