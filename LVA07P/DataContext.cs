namespace LVA07P
{
    using LVA07P.Data;
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("name = con")
        {


        }
        DbSet <Student> Students { get; set; }
        DbSet <Professor> Professors { get; set; }
        DbSet <Course> Courses { get; set; }
        DbSet <Exam> Exams { get; set; }
        DbSet <Subject> Subjects { get; set; }
        DbSet <Enrollment> Enrollments { get; set; }
        DbSet <ExamQuestion> ExamQuestions { get; set; }
        DbSet <Question> Questions { get; set; }
        DbSet <Response> Responses { get; set; }
        DbSet <QuestionType> QuestionTypes { get; set; }
    }
}