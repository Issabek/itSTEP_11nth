using System;

namespace Person
{
    public interface IPerson
    {
        int Course { get; set; }
        string Name { get; set; }
        string ToString();
        bool Equals(Object obj);
    }
    
}
