using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_APPLICATION.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
    
    }
}