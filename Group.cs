using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Group
    {
        private Student[] studentss = new Student[0];
        public string No;
        public byte Limit;


        public Group(string groupName, byte limit)
        {
            No = groupName;
            Limit = limit;
        }

        public void addStudents()
        {
            Console.WriteLine("Please, enter the student's name:");
            string name_of_student = Console.ReadLine();
            Console.WriteLine("Please, enter the student's surname:");
            string surnamename_of_student = Console.ReadLine();

            Student std = new Student(name_of_student , surnamename_of_student);

            if (studentss.Length < Limit)
            {
                Array.Resize(ref studentss, studentss.Length + 1);
                studentss[studentss.Length - 1] = std;
            }

        }

        public void getStudentss() 
        {
            Console.WriteLine(No + " Students below: \n");

            foreach (Student item in studentss)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
