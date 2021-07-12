using Microsoft.EntityFrameworkCore;
using SchoolProject_GD.Domain;
using SchoolProject_GD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD.Repository
{
    public class StudentSubjectRepository : IStudentSubjectRepository
    {
        protected SchoolDbContext _context;
        public StudentSubjectRepository(SchoolDbContext context)
        {
            _context = context;
        }
        public void AddStudentSubject(StudentSubject studentSubject)
        {
            _context.StudentSubjects.Add(studentSubject);
            Save();

        }

        public bool SetPoint(int personalId, string subjectName, int point)
        {
            try
            {
                StudentSubject studentSubject = _context.StudentSubjects.FirstOrDefault(x =>
                x.StudentPersonalId == personalId && 
                x.SubjectName == subjectName);
                studentSubject.StudentPoint = point;
                _context.Entry(studentSubject).State = EntityState.Modified;
                Save();
                return true;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;//erorebis failshi shenaxva
                return false;
            }
        }

        public List<StudentSubject> GetStudentPoint(int personalId)
        {
            List<StudentSubject> studentSubjects = new List<StudentSubject>();
            foreach (var item in _context.StudentSubjects)
            {
                if (item.StudentPersonalId == personalId)
                {
                    studentSubjects.Add(item);
                }
            }

            return studentSubjects;
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
