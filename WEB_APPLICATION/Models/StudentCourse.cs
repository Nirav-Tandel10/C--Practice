using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_APPLICATION.Models
{
    public class StudentCourse
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }


    }
}