namespace LVA07P
{
    using LVA07P.Data;
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("name = con")
        {
        }
        public DbSet <Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
    }
}