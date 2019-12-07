using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Subject
{
    class SubjectInput
    {
        public Subject InputNewSubject()
        {
            Console.Write("Input subject Name: ");
            string name = Console.ReadLine();
            Console.Write("Input subject hours: ");
            int hours = int.Parse(Console.ReadLine());

            return new   Subject (name, hours);
        }

        public string InputIndexSubject()
        {
            Console.Write("Input Id: ");
            return Console.ReadLine();
        }
        public string InputNameSubject()
        {
            Console.Write("Name subject: ");
            return Console.ReadLine();
        }



    }
}
