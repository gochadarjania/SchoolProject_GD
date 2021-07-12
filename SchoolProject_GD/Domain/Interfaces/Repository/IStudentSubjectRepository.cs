using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD.Domain.Interfaces.Repository
{
    public interface IStudentSubjectRepository
    {
        public void AddStudentSubject(StudentSubject studentSubject);
        public bool SetPoint(int personalId, string subjectName, int point);
        public List<StudentSubject> GetStudentPoint(int personalId);
        public void Save();
    }
}
