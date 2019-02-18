using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstTest
{
    public abstract class DomainModel
    {

    }

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment : DomainModel
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
                
        public virtual Student Student { get; set; }
    }

    public class Student : DomainModel
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }        
    }

    public class Registration : DomainModel
    {
        public int ID { get; set; }
        public string University     { get; set; }
        public string Affiliation { get; set; }
        public int RegistrationNo { get; set; }
    }
}
