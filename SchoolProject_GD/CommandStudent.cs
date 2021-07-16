using SchoolProject_GD.Domain;
using SchoolProject_GD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD
{
    public class CommandStudent
    {
        IStudentRepository _studentRepository;    
        public CommandStudent(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void RunStudent()
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(',');

            phrase = "";

            foreach (var item in words)
            {
                phrase += item;
            }

            words = phrase.Split(' ');


            if (words[0] == "Add" && words[1] == "Person")
            {
                Student st = new Student();

                st.StudentName = words[2];
                st.StudentLastName = words[3];
                st.StudentPersonalId = Convert.ToInt32(words[4]);
                st.StudentAge = Convert.ToInt32(words[5]);
                st.StudentGender = Convert.ToInt32(words[6]);

                _studentRepository.AddStudent(st);
            }


            if (words[0] == "Remove" && words[1] == "Person")
            {
                _studentRepository.RemoveStudent(Convert.ToInt32(words[2]));
            }
        }             

    }
}
