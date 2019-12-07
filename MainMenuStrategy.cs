using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
    class MainMenuStrategy:IntefaceSubjectTeacher
    {
        public bool IsDone { get; private set; }
        private Menu activeMenu;
        private IntefaceSubjectTeacher teachersMenuStrategy;
        private IntefaceSubjectTeacher subjectsMenuStrategy;
        private IntefaceSubjectTeacher teacherSubjectsMenuStrategy;

        public MainMenuStrategy(IntefaceSubjectTeacher teachersMenuStrategy, IntefaceSubjectTeacher subjectsMenuStrategy, IntefaceSubjectTeacher teacherSubjectsMenuStrategy)
        {
            this.teachersMenuStrategy = teachersMenuStrategy;
            this.subjectsMenuStrategy = subjectsMenuStrategy;
            this.teacherSubjectsMenuStrategy = teacherSubjectsMenuStrategy;
            this.activeMenu = new Menu();
        }
        public void Init()
        {
            Console.Clear();
        }
        public void Do()
            {
                Console.WriteLine(new string ('-', 20) + "Menu" + new string ('-', 20));
                Console.WriteLine("Press the key number of menu");
                Console.WriteLine("1 - Teacher menu");
                Console.WriteLine("2 - Subject menu");
                Console.WriteLine("3 - TeacherSubject menu");
                Console.WriteLine("0 - Exit");

            ConsoleKey keyPressed = Console.ReadKey().Key;
            Console.Clear();
            switch (keyPressed)
                {
                    case ConsoleKey.D1:
                    activeMenu.SetStrategy(teachersMenuStrategy);
                    activeMenu.Run();
                    break;
                    case ConsoleKey.D2:
                    activeMenu.SetStrategy(subjectsMenuStrategy);
                    activeMenu.Run();
                    break;
                    case ConsoleKey.D3:
                    activeMenu.SetStrategy(teacherSubjectsMenuStrategy);
                    activeMenu.Run();
                    break;
                    case ConsoleKey.D0:
                        Console.WriteLine("Good by!");
                    IsDone = true;
                    break;
                    default:
                        Console.WriteLine("Wrong key command!");
                        break;
                }
}
        public void Finish()
        {
            Console.Clear();
            Console.WriteLine($"Application closed {DateTime.Now.ToString()}. Press any key to exit.", ConsoleColor.Yellow);
        }
    }
}
