using System;
using System.Collections.Generic;
using System.Text;

namespace OutstandingLibrary
{
    public class Student : OutClass
    {
        int Marks;
        public Student()
        {

        }
        public Student(string name, int Marks) : base(name)
        {
            this.Marks = Marks;
        }
        public override bool IsOutstanding()
        {
            if (Marks > 85)
                return true;
            else
                return false;
        }
        public string show()
        {
            return name + " and " + Marks.ToString();
        }

    }
}
