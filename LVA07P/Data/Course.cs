namespace LVA07P.Data
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }

        public Professor Professor { get; set; }
        public Subject Subject { get; set; }
        public ICollection <Exam> Exams { get; set; }
        public ICollection <Enrollment> Enrollments { get; set; }



    }
}
