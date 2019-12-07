using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
    class IdInput
    {
        public TeacherSubject InputNewTeacherSubject()
        {
            Console.Write("Input IdTeacher ");
            int idTeacher = int.Parse(Console.ReadLine());
            Console.Write("Input idSubject ");
            int idSubject = int.Parse(Console.ReadLine());

            return new TeacherSubject(idTeacher, idSubject);
        }
        public string InputIndex()
        {
            Console.Write("Input Id: ");
            return Console.ReadLine();
        }

        public int InputName()
        {
            Console.Write("Name Idteacher: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
