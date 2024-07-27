using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_APPLICATION.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}