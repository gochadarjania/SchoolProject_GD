using SchoolProject_GD.Domain;
using SchoolProject_GD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        protected SchoolDbContext _context;
        public SubjectRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Subject subject)
        {
            _context.Subjects.Add(subject);
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
