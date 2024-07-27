using System;
using System.Collections.Generic;

namespace Session_Practice_DBFirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? City { get; set; }
    }
}
