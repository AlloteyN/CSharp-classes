using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    internal class Student
    {
        public string name;
        public double gpa;
        public static int studentCount = 0;
        public Student(string name, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
            studentCount++;
        }

        public bool HasHonors()
        {
            if (this.gpa > 2.5)
            {
                return true;
            }
            return false;
        }
    }
}
