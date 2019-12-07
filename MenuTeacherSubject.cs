using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
    class MenuTeacherSubject:IntefaceSubjectTeacher
    {
        public bool IsDone { get; private set; }
        public DBTeacherSubject _dBTeacherSubject;
        private string query;

        public MenuTeacherSubject(DBTeacherSubject dBTeacherSubject)
        {
            _dBTeacherSubject = dBTeacherSubject;
        }
        public void Init()
        {
            Console.Clear();
            Console.WriteLine(new string('=', 20) + "Subject Informaition" + new string('=', 20));
        }
        public void Do()
        {
            Console.WriteLine("Options Subject: ");
            Console.WriteLine("1 - Show IdTeacher idSubject: ");
            Console.WriteLine("2 - Add IdTeacher idSubject: ");
            Console.WriteLine("3 - Delete IdTeacher idSubject: ");
            Console.WriteLine("4 - Find IdTeacher  ");
            Console.WriteLine("5 - Find idSubject  ");
            Console.WriteLine("6 - Find id  ");

            Console.WriteLine("7 - Update: ");
            Console.WriteLine("0 - Exite IdTeacher idSubject");
            
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    _dBTeacherSubject.ShowTeachers();
                    Console.WriteLine();
                    break;
                case ConsoleKey.D2:
                    _dBTeacherSubject.InputTeacherSubject();
                    break;
                case ConsoleKey.D3:
                    _dBTeacherSubject.DeleteTeacherByName(_dBTeacherSubject.idInput.InputName());

                    Console.WriteLine();
                    break;
                case ConsoleKey.D4:
                    Console.Write("IdTeacher: ");
                    query = Console.ReadLine();
                    Console.WriteLine(_dBTeacherSubject.GetSubjectTeacherInfoByFilter ( query, DBTeacherSubject.Filter.idTeacher));
                    Console.WriteLine();
                    break;
                case ConsoleKey.D5:
                    Console.Write("idSubject: ");
                    query = Console.ReadLine();
                    Console.WriteLine(_dBTeacherSubject.GetSubjectTeacherInfoByFilter(query, DBTeacherSubject.Filter.idSubject));
                    break;
                case ConsoleKey.D6:
                    Console.Write("id: ");
                    query = Console.ReadLine();
                    Console.WriteLine(_dBTeacherSubject.GetSubjectTeacherInfoByFilter(query, DBTeacherSubject.Filter.id));
                    break;
                case ConsoleKey.D7:
                    _dBTeacherSubject.UpdateTeacherByName(_dBTeacherSubject.idInput.InputName());

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

