namespace LVA07P.Data
{
    using System.Collections.Generic;
    public class Question
    {
        public int Id { get; set; }
        public int QuestionNumber { get; set; }
        public string Content { get; set; }
        public ICollection <ExamQuestion> ExamQuestions { get; set; }
        public QuestionType QuestionType { get; set; }
    }
}
