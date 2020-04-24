namespace LVA07P.Data
{
    using System.Collections.Generic;
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }

        public ICollection <Course> Courses { get; set; }
    }
}
