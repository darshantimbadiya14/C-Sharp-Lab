using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23
{
    public class Result : Exam, Classify
    {
        public bool Pass(int mark)
        {
            if (mark >= 50)
                return true;
            else
                return false;
        }

        public string Division(int average)
        {
            if (average >= 60)
                return "First";
            else if (average >= 50)
                return "Second";
            else
                return "No Division";
        }
    }
}