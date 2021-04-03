using System;
using Person;
namespace Student
{
    public class Student : IPerson
    {
        public int Course { get ; set ; }
        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("{0} ---- {1}", Name, Course);
        }
    }
}
