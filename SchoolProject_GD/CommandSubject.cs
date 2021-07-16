using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject_GD
{
    public class CommandSubject
    {
        public void RunSubject()
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(',');

            phrase = "";

            foreach (var item in words)
            {
                phrase += item;
            }

            words = phrase.Split(' ');

            //if (words[0] == "Add" && words[1] == "Subject")
            //{
            //    AddSubject(subject);
            //}

        }
    }
}
