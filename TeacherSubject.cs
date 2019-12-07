using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
    class TeacherSubject
    {

        public int idTeacher;
        public int idSubject;
        public int id;
        public static int count = 0;

        public TeacherSubject(int idTeacher, int idSubject)
        {
            this.idTeacher = idTeacher;
            this.idSubject = idSubject;
            this.id = count++;
        }

        public override string ToString()
        {
            return string.Format("[id: {0},idTeacher: {1},idSubject: {2} ] ", id, idTeacher, idSubject);
        }
    }
}
