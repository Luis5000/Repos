namespace LVA07P.Data
{
    using System.Collections.Generic;
    public class ExamQuestion
    {
        public int Id { get; set; }
        public int QuestionNumber { get; set; }
        public string Content { get; set; }
        
        public Exam Exam { get; set; }
        public Question Question { get; set; }
        public ICollection <Response> Responses { get; set; }
    }
}
