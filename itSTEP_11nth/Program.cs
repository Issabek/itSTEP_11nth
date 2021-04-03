using System;
using System.Collections.Generic;
using Teacher;
using System.Linq;
using StudentWithAdviser;
using Person;
namespace itSTEP_11nth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void StudsAndTeachers(List<IPerson> ts)
        {
            List<Teacher.Teacher> t = ts.Where(t => t is Teacher.Teacher).ToList().ConvertAll(t=>(Teacher.Teacher)t);
            int Students = t.Sum(t => t.students.Count);
            Console.WriteLine("There are {0} teachers and {1} students",t.Count,Students);
        }
    }

    
}
