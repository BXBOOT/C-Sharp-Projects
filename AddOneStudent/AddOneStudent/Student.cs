using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StudentDataApp
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
