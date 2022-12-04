using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string group;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }

    }
}
