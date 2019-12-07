using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Teacher
{
    class TeacherManager
    {
        public Teacher InputNewTeacher()
        {
            Console.Write("Name Teacher: ");
            string nameTeacher = Console.ReadLine();
            Console.Write("Birth Teacher: ");
            DateTime birthTeacher = DateTime.Parse(Console.ReadLine());
            return new Teacher(nameTeacher, birthTeacher);
        }
        public string InputIndex()
        {
            Console.Write("Input Id: ");
            return Console.ReadLine();
        }
        public string InputName()
        {
            Console.Write("Name teacher: ");
            return Console.ReadLine();
        }
    }
}
