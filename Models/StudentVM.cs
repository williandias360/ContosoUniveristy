using System;
namespace ContosoUniveristy.Models
{
    public class StudentVM
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate {get; set;}
    }
}