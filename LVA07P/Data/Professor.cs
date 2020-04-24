namespace LVA07P.Data
{
    using System;
    using System.Collections.Generic;
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HiringDate { get; set; }

        public ICollection <Course> Courses { get; set; }
    }
}
