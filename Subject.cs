using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Subject
{
    class Subject
    {
       public  int IdSubject;
       public string Name;
        public int Hours;
        public static int Count = 0;


        public Subject(string Name, int Hours)
        {
            this.Name = Name;
            this.Hours = Hours;
            this.IdSubject = Count++;
        }

        public override string ToString()
        {
            return string.Format("[IdSubject: {0}; Name: {1}; Hours: {2}]", IdSubject, Name, Hours );
        }
    }
}
