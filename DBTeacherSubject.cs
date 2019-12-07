using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
    class DBTeacherSubject
    {
        public List<TeacherSubject> teacherSubjects;
        public IdInput idInput;
      

     

        public DBTeacherSubject()
    {
        teacherSubjects = new List<TeacherSubject>();
        idInput = new IdInput();


    }
        public void AddTeacherSubject(TeacherSubject teacherSubject)
        {
            teacherSubjects.Add(teacherSubject);
        }

        public void InputTeacherSubject()
        {
            AddTeacherSubject(idInput.InputNewTeacherSubject());
        }





        public enum Filter {id,idTeacher, idSubject};

        public string GetSubjectTeacherInfoByFilter(string query, Filter filter)
        {
            string response = string.Empty;
            int count = 0;

            if (filter == Filter.idTeacher)
            {
                foreach (var person in teacherSubjects)
                {
                    if (person.idTeacher.ToString() == query)
                    {
                        count++;
                        response += person.ToString() + "\n";
                    }
                }
            }
            else if (filter == Filter.idSubject)
            {
                foreach (var person in teacherSubjects)
                {
                    if (person.idSubject.ToString() == query)
                    {
                        count++;
                        response += person.ToString() + "\n";
                    }
                }
            }
            else
            {
                foreach (var person in teacherSubjects)
                {
                    if (person.id == int.Parse(query))
                    {
                        count++;
                        response += person.ToString() + "\n";
                    }
                }
            }

            if (count > 0)
                return $"There are {count} results with {filter.ToString()}: {query}\n{response}";
            else
                return $"There are no Teacher or subject id with {filter.ToString()}: {query}";
        }

       


        public TeacherSubject FindTeacherSubjectByName(int id)
        {
            foreach (var persone in teacherSubjects)
            {
                if (persone.idTeacher == id)
                {
                  
                    return persone;
                }
            }
            Console.WriteLine(" Can't find teacher by this name");
            return null;
        }


        public void DeleteTeacherByName(int id)
        {
            var teacher = FindTeacherSubjectByName(id);
            if (teacher != null)
            {
                teacherSubjects.Remove(teacher);
            }
        }



        public void UpdateTeacherByName(int id)
        {
            List<TeacherSubject> _teacherSubjects = ShowTeacherByName(id);
            int _teacherId;                                             // тут сохраним ид учителя которого нужно обновить
            if (_teacherSubjects.Count == 0)
                return;
            else if (_teacherSubjects.Count > 1)
            {
                _teacherId = int.Parse(idInput.InputIndex());    // если больше 1го учителя подходит под описание уточнить какого именно
            }
            else
            {
                _teacherId = teacherSubjects[0].idTeacher;             // если  1 то сохраняем его ид
            }

            if (_teacherId < teacherSubjects.Count) // если пользователь ввел коректктное число то можем  обновить
            {
                teacherSubjects[_teacherId] = idInput.InputNewTeacherSubject(); //обновляем
            }
            else
            {
                Console.WriteLine("No match");
            }


        }
       

        public List<TeacherSubject> ShowTeacherByName(int id)
        {
            List<TeacherSubject> _teacers = new List<TeacherSubject>(id);
            if (_teacers.Count > 0)
            {
                foreach (var t in _teacers)
                {
                    Console.WriteLine(t.ToString());
                }
            }
            else
            {
                Console.WriteLine("No match");
            }
            return _teacers;
        }

        public void ShowTeachers()
        {
            Console.WriteLine("Teacher Subject: ");
            if (teacherSubjects.Count == 0)
            {
                Console.WriteLine("~Empty ");
            }
            else
            {
                foreach (var subTeacher in teacherSubjects)
                {
                    Console.WriteLine(subTeacher.ToString());
                }

            }
        }

    } 
   
}
