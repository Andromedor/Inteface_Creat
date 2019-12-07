using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject.Subject
{
    class DBSubjects
    {
        public List<Subject> subjects;
        public SubjectInput subjectInput;

        public DBSubjects()
        {
            subjects = new List<Subject>();
            subjectInput = new SubjectInput();
        }
        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void InputSubject()
        {
            AddSubject(subjectInput.InputNewSubject());
        }

        public Subject FindSubjectByName(string name) 
        {
            foreach(var sub in subjects)
            {
                if(sub.Name == name)
                {
                    return sub;
                }
               
            }
            Console.WriteLine(" Can't find teacher by this name");
                return null;
        }
        public List<Subject> FindSubjectSimbyl(string name)
        {
            List<Subject> _subjects = new List<Subject>();
            int length = name.Length;
            foreach(var sub in subjects)
            {
                bool match = false;
                for(int i =0; i< length; i++)
                {
                    match = sub.Name[i].ToString() == name[i].ToString();
                    if (!match)
                    {
                        break;
                    }
                    
                }
                if (match)
                    {
                        _subjects.Add(sub);
                    }

            }
            return _subjects;
        }
        public void DeleteSubjectByName(string name)
        {
            var subject = FindSubjectByName(name);
            if(subject != null)
            {
                subjects.Remove(subject);
            }
        }
        public void UpdateSubjectByName(string name)
        {
            List<Subject> _subjects = ShowSubjectByName(name);
            int _idSubject;
            if (_subjects.Count == 0)
            {
                return;
            }
            else if(_subjects.Count > 1)
            {
                _idSubject = int.Parse(subjectInput.InputIndexSubject());
            }
            else
            {
                _idSubject = subjects[0].IdSubject;
            }
            if (_idSubject < subjects.Count)
            {
                subjects[_idSubject] = subjectInput.InputNewSubject();
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
        public List<Subject> ShowSubjectByName(string name)
        {
            List<Subject> _subjects = FindSubjectSimbyl(name);
            if(_subjects.Count > 0)
            {
                foreach (var t in _subjects)
                {
                    Console.WriteLine(t);
                }

            }
            else
            {
                Console.WriteLine("No match");
            }
            return _subjects;
        }

            public void ShowSubjects()
        {
            Console.WriteLine("Subject: ");
            if (subjects.Count == 0)
            {
                Console.WriteLine("~Empty ");
            }
            else
            {
                foreach (var subject in subjects)
                {
                    Console.WriteLine(subject.ToString());
                }

            }
        }
    }
}
