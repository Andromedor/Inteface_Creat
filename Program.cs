using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherSubject.Teacher;
using TeacherSubject.Subject;

namespace TeacherSubject
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
          

            DBTeahcer dBTeahcer = new DBTeahcer();
            DBSubjects dBSubjects = new DBSubjects();
            DBTeacherSubject dBTeacherSubject = new DBTeacherSubject();


            SubjectMenu subjectMenu = new SubjectMenu(dBSubjects);
            MenuTeacher menuTeacher = new MenuTeacher(dBTeahcer);
            MenuTeacherSubject menuTeacherSubject = new MenuTeacherSubject(dBTeacherSubject);

            MainMenuStrategy mainMenuStrategy = new MainMenuStrategy(menuTeacher, subjectMenu, menuTeacherSubject);
            Menu mainMenu = new Menu(mainMenuStrategy);

            mainMenu.Run();

        }
    }
}
