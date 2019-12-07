using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Teacher
{
    class Teacher
    {
        public int idTeacher;
        public string nameTeacher;
        public DateTime birthTeacher;
        public static int count = 0;

       

        public Teacher(string nameTeacher, DateTime birthTeacher)
        {
            this.nameTeacher = nameTeacher;
            this.birthTeacher = birthTeacher;
            this.idTeacher = count++;
        }

      
        public override string ToString()
        {
            return string.Format("[idTeacher: {0}; nameTeacher: {1}; birthTicher: {2};]", idTeacher, nameTeacher,birthTeacher.ToShortDateString() );
        }

      
       
    }
}
