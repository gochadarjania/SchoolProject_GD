using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD
{
    public class CommandStudentSubject
    {
        public void RunStudentSubject()
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(',');

            phrase = "";

            foreach (var item in words)
            {
                phrase += item;
            }

            words = phrase.Split(' ');

            //if (words[0] == "Add" && words[1] == "Person" && words[3] == "Subject")
            //{
            //    AddPersonToSubject(person);
            //}

            //if (words[0] == "Set" && words[1] == "Point")
            //{
            //    SetPoint(personalId, subject, point);
            //}

            //if (words[0] == "Get" && words[1] == "Person" && words[3] == "Point")
            //{
            //    if (subject == null && personalId != null)
            //    {
            //        GetPersonPoint(personId);
            //    }

            //    if (subject != null && personalId != null)
            //    {
            //        GetPersonPoint(personId, subject);
            //    }


            //    if (subject == null && personalId == null)
            //    {
            //        GetPersonPoint();
            //    }

            //}
        }
    }
}
