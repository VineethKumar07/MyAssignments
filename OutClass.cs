using System;

namespace OutstandingLibrary
{
    public class OutClass
    {
        protected String name;
        public OutClass()
        {

        }
        public OutClass(string name)
        {
            this.name = name;
        }
        public virtual bool IsOutstanding()
        {
            return true;
        }
    }
    public class Professor : OutClass
    {
        int Publications;
        public Professor()
        {

        }
        public Professor(string name, int Publications) : base(name)
        {
            this.Publications = Publications;
        }
        public override bool IsOutstanding()
        {
            if (Publications >= 5)
                return true;
            else
                return false;
        }
        public string printvalues()
        {
            return name + " and " + Publications.ToString();
        }

    }
   public class Student: OutClass
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
