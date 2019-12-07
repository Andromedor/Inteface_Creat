using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
    struct Menu
    {
        private IntefaceSubjectTeacher itsInstance ;

        public Menu(IntefaceSubjectTeacher strategy)
        {
            this.itsInstance = strategy;
        }

       
        public void SetStrategy(IntefaceSubjectTeacher strategy)
        {
            this.itsInstance = strategy;
        }
      
        public void Run()
        {
            itsInstance.Init();
            while (!itsInstance.IsDone)
                itsInstance.Do();
            itsInstance.Finish();
        }
    }
}
