using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //run the program by commenting enrollments and then rerun by adding enrollments in db first approach
            var efDbContext = new EfDbContext();

            var regDetial = efDbContext.GetQuery<Registration>().FirstOrDefault();
                        
            var allStudents = efDbContext.GetQuery<Student>().ToList();
            if (!allStudents.Any())
            {
                var studentsToAdd = new List<Student>
                {
                    new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                    new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                    new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                    new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                    new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                    new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                    new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                    new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
                };

                efDbContext.Set<Student>().AddRange(studentsToAdd);            
                efDbContext.SaveChanges();
                                
                var enrollments = new List<Enrollment>
                {
                    new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                    new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                    new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                    new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                    new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                    new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                    new Enrollment{StudentID=3,CourseID=1050},
                    new Enrollment{StudentID=4,CourseID=1050,},
                    new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                    new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                    new Enrollment{StudentID=6,CourseID=1045},
                    new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
                };

                efDbContext.Enrollments.AddRange(enrollments);
                efDbContext.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
