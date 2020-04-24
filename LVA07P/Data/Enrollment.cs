namespace LVA07P.Data
{
    using System;
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime DateAssignment { get; set; }
        public DateTime DateLow { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
