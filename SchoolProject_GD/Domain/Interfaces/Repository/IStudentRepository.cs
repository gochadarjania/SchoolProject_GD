using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        public void RemoveStudent(int personalId);
        public void AddStudent(Student student);
        public void Save();

    }
}
