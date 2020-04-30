namespace LVA07P.Data
{
    using System.Collections.Generic;
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }


        public ICollection <Response> Responses { get; set; }
        public ICollection <Enrollment> Enrollments { get; set; }


    }
}
