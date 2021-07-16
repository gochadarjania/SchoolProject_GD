using Microsoft.Extensions.Configuration;
using SchoolProject_GD.Domain.Interfaces.Repository;
using System;

namespace SchoolProject_GD
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandStudent commandStudent = new CommandStudent();

            commandStudent.RunStudent();
        }
    }
}
