using Scaffolding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding.Data
{
    public class DBInitializer
    {
        public static void Initialize(ScaffoldingContext context)
        {
            context.Database.EnsureCreated();

            if(!context.Students.Any())
            {
                var students = new List<Student>()
                {
                    new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                    new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                    new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")}
                };
                
                foreach(var student in students)
                {
                    context.Students.Add(student);
                }
            }

            context.SaveChanges();

            if (!context.Courses.Any())
            {
                var courses = new List<Course>()
                {
                    new Course{CourseID=1050,Title="Chemistry",Credits=3},
                    new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                    new Course{CourseID=4041,Title="Macroeconomics",Credits=3}
                };

                foreach (var course in courses)
                {
                    context.Courses.Add(course);
                }
            }

            context.SaveChanges();

            if (!context.Enrollments.Any())
            {
                var enrollments = new List<Enrollment>()
                {
                    new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                    new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                    new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B}
                };

                foreach (var enrollment in enrollments)
                {
                    context.Enrollments.Add(enrollment);
                }
            }

            context.SaveChanges();
        }
    }
}
