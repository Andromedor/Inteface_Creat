using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Teacher
{
    class MenuTeacher : IntefaceSubjectTeacher
    {
        public bool IsDone { get; private set; }
        
        private DBTeahcer _dBTeahcer;
       
        public MenuTeacher(DBTeahcer dBTeahcer)
        {
            _dBTeahcer = dBTeahcer;
        }

        public void Init()
        {
            Console.Clear();
            Console.WriteLine(new string('=',20) + "Teacher Informaition" + new string('=',20));
        }
        public void Do()
        {
            Console.WriteLine("Options Teacher");
            Console.WriteLine("1 - Show Teacher");
            Console.WriteLine("2 - Add Teacher");
            Console.WriteLine("3 - Delete Teacher");
            Console.WriteLine("4 - Find Teacher");
            Console.WriteLine("5 - Update");
            Console.WriteLine("0 - Exite Teacher");
          
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    _dBTeahcer.ShowTeachers();
                    Console.WriteLine();
                    break;
                case ConsoleKey.D2:
                    _dBTeahcer.InputNewTeaher();
                    Console.WriteLine();
                    break;
                case ConsoleKey.D3:
                    _dBTeahcer.DeleteTeacherByName(_dBTeahcer.teacherManager.InputName());
                    Console.WriteLine();
                    break;
                case ConsoleKey.D4:
                    _dBTeahcer.ShowTeacherByName(_dBTeahcer.teacherManager.InputName());
                    break;
                case ConsoleKey.D5:
                    _dBTeahcer.UpdateTeacherByName(_dBTeahcer.teacherManager.InputName());
                    break;
                case ConsoleKey.D0:
                    IsDone = true;
                    break;
                default:
                    Console.WriteLine("Oshibka");
                    break;
            }

        }
        public void Finish()
        {
            Console.WriteLine(new string('-', 32));
            IsDone = false;
        }
    }
}
