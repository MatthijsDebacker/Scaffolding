using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding.Models
{
    public enum Grade
    {
        [Display(Name = "A")]
        A,
        [Display(Name = "B")]
        B,
        [Display(Name = "C")]
        C,
        [Display(Name = "D")]
        D,
        [Display(Name = "F")]
        F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade Grade { get; set; }

        public Student EnStudent { get; set; }
        public Course EnCourse { get; set; }
    }
}
