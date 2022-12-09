using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;
using StudentDataApp;

public class Program
{
    public static void Main()
    {
        using (var c = new SchoolContext())
        {
            var student = new Student()
            {
                StudentName = "Mike",
                LastName = "Student",
                DateOfBirth = DateTime.Today
            };

            c.Students.Add(student);
            c.SaveChanges();
        }
    }
}
