using System;
using System.Collections.Generic;
using System.Text;

namespace OutstandingLibrary
{
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
}
