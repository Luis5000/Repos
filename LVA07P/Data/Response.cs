namespace LVA07P.Data
{
    public class Response
    {
        public int Id { get; set; }
        public string Answer { get; set; }

        public Student Student { get; set; }
        public ExamQuestion ExamQuestion { get; set; }
    }
}
