namespace LVA07P.Data
{
    using System.Collections.Generic;
    public class Exam
    {
        public int Id { get; set; }
        public string type { get; set; }
        public string level { get; set; }

        public Course Course { get; set; }
        public ICollection <ExamQuestion> ExamQuestions { get; set; }

    }
}
