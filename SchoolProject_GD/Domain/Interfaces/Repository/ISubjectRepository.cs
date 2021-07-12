using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD.Domain.Interfaces.Repository
{
    public interface ISubjectRepository
    {
        public void AddStudent(Subject subject);
        public void Save();
    }
}
