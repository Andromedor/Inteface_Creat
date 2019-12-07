using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Subject
{
    class SubjectMenu : IntefaceSubjectTeacher
    {
        public bool IsDone { get; private set; }
        private DBSubjects _dBSubjects;
       
        public SubjectMenu(DBSubjects dBSubjects)
        {
            _dBSubjects = dBSubjects;
        }
        public void Init()
        {
            Console.Clear();
            Console.WriteLine(new string('=', 20) + "Subject Informaition" + new string('=', 20));
        }


        public void Do()
        {
            Console.WriteLine("Options Subject: ");
            Console.WriteLine("1 - Show Subject: ");
            Console.WriteLine("2 - Add Subject: ");
            Console.WriteLine("3 - Delete Subject: ");
            Console.WriteLine("4 - Find Subject: ");
            Console.WriteLine("5 - Update: ");
            Console.WriteLine("0 - Exite Subject");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    _dBSubjects.ShowSubjects();
                    Console.WriteLine();
                    break;
                case ConsoleKey.D2:
                    _dBSubjects.InputSubject();
                    Console.WriteLine();
                    break;
                case ConsoleKey.D3:
                    _dBSubjects.DeleteSubjectByName(_dBSubjects.subjectInput.InputNameSubject());

                    Console.WriteLine();
                    break;
                case ConsoleKey.D4:
                    _dBSubjects.ShowSubjectByName(_dBSubjects.subjectInput.InputNameSubject());

                    break;
                case ConsoleKey.D5:
                    _dBSubjects.UpdateSubjectByName(_dBSubjects.subjectInput.InputNameSubject());

                    break;
                case ConsoleKey.D0:
                    IsDone = true;
                    break;
                default:
                    Console.WriteLine("Oshibka");
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine();
        }





        public void Finish()
        {
            Console.WriteLine(new string('-', 32));
            IsDone = false;
        }
    }
}