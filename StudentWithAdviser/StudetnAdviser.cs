using System;
using Teacher;
using Student;
using System.Collections.Generic;

namespace StudentWithAdviser
{
    public class StudentAndAdviser:Student.Student
    {
        public Teacher.Teacher adviser { get; set; }

        public override bool Equals(object obj)
        {
            StudentAndAdviser t = obj as StudentAndAdviser;
            return this.Name == t.Name && this.Course == t.Course && t.adviser.Name == this.adviser.Name && t.adviser.Course == this.adviser.Course ? true : false;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} adviser: {2} {3}", this.Name, this.Course, adviser.Name, adviser.Course);
        }
        public static StudentAndAdviser RandomStudent(List<StudentAndAdviser> t)
        {
            Random rnd = new Random();
            return t[rnd.Next(t.Count)];
        }

        public static bool operator ==(StudentAndAdviser a, StudentAndAdviser b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(StudentAndAdviser a, StudentAndAdviser b)
        {
            return a.Equals(b);
        }
    }
}
