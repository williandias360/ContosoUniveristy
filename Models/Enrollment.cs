namespace ContosoUniversity.Models
{
    public class Enrollment
    {
        public int EnrollmentIdD { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}