using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Teacher
{
    class DBTeahcer
    {
        public List<Teacher> teachers;

        public TeacherManager teacherManager;

        public DBTeahcer()
        {
            teachers = new List<Teacher>();
            teacherManager = new TeacherManager();
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void InputNewTeaher()
        {
            AddTeacher(teacherManager.InputNewTeacher());
        }


        public Teacher FindTeacherByName(string name)
        {

            foreach (var persone in teachers)
            {
                if (persone.nameTeacher == name)
                {
                    return persone;
                }
            }
            Console.WriteLine(" Can't find teacher by this name");
            return null;
        }

        public List<Teacher> FindTeacherBySymbols(string name)
        {
            List<Teacher> _teachers = new List<Teacher>(); // создаем пустой список в который будем записывать учителей которые подходят
            int length = name.Length; // создаем числовое значение равное количеству символов переданому в параметрах         
            foreach (var persone in teachers)
            {
                bool match = false; // логическая переменная которая будет в себе хвранить текущее значение совпаденя
                for (int i = 0; i < length; i++)
                {
                    match = persone.nameTeacher[i].ToString() == name[i].ToString(); // изменение логической переменной в зависимости от совпадения
                    if (!match)  // исли словили не совпадение выйти из проверки этого учителя и перейти к следующему
                        break;
                }
                if (match) //если совпало тогда добавляем учителя в наш список подходящихъ учителей
                {
                    _teachers.Add(persone);
                }

            }
            return _teachers;
        }

        public void DeleteTeacherByName(string name)
        {
            var teacher = FindTeacherByName(name);
            if (teacher != null)
            {
                teachers.Remove(teacher);
            }
        }




        public void ShowTeachers()
        {
            Console.WriteLine("Teacher: ");
            if (teachers.Count == 0)
            {
                Console.WriteLine("~Empty ");
            }
            else
            {
                foreach (var teacher in teachers)
                {
                    Console.WriteLine(teacher.ToString());
                }

            }
        }
        public void UpdateTeacherByName(string name)
        {
            List<Teacher> _teachers = ShowTeacherByName(name);
            int _teacherId;                                             // тут сохраним ид учителя которого нужно обновить
            if (_teachers.Count == 0)
                return;
            else if (_teachers.Count > 1)                             
            {
                _teacherId = int.Parse(teacherManager.InputIndex());    // если больше 1го учителя подходит под описание уточнить какого именно
            }
            else
            {
                _teacherId = teachers[0].idTeacher;             // если  1 то сохраняем его ид
            }

            if ( _teacherId < teachers.Count ) // если пользователь ввел коректктное число то можем  обновить
            {
                teachers[_teacherId] = teacherManager.InputNewTeacher(); //обновляем
            }
            else
            {
                Console.WriteLine("No match");
            }


        }
        public List<Teacher> ShowTeacherByName(string name)
        {
            List<Teacher> _teacers = FindTeacherBySymbols(name);
            if (_teacers.Count > 0)
            {
                foreach (var t in _teacers)
                {
                    Console.WriteLine(t);
                }               
            }
            else
            {               
                Console.WriteLine("No match");              
            }
            return _teacers;
        }
    }
}

