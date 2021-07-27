using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mircrosoft_CodeCamp_Student_Prompt.Models
{
    public class Student
    {
        public string FName { get; set; }
        public string LName{ get; set; }

        public Student(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }

    }
}
