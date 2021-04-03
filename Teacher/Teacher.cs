using System;
using System.Collections.Generic;
using Student;
namespace Teacher
{
    public class Teacher: Student.Student
    {
        public new string Name { get; set; }
        public new int Course { get; set; }
        public List<Student.Student> students { get; set; }
        public override void Print()
        {
            Console.WriteLine("{0} ---- {1}", Name, Course);
        }
        public override bool Equals(object obj)
        {
            Teacher t = obj as Teacher;
            return this.Name == t.Name && this.Course == t.Course&&t.students.Count==this.students.Count? true : false;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} Students count: {2} ",this.Name,this.Course,students.Count);
        }

        public static Teacher RandomTeacher(List<Teacher> t)
        {
            Random rnd = new Random();
            return t[rnd.Next(t.Count)];
        }
        public static bool operator ==(Teacher a, Teacher b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Teacher a, Teacher b)
        {
            return a.Equals(b);
        }
    }
}
