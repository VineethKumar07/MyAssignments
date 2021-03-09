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
    
   

    
}
