using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
    interface IntefaceSubjectTeacher
    {

       bool IsDone { get; }
        void Init();
       void Do();
       void Finish();
        
    }
}
