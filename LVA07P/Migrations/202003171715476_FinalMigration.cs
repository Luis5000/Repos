namespace LVA07P.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Level = c.String(),
                        Description = c.String(),
                        DateBegin = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        Professor_Id = c.Int(),
                        Subject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professors", t => t.Professor_Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .Index(t => t.Professor_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAssignment = c.DateTime(nullable: false),
                        DateLow = c.DateTime(nullable: false),
                        Course_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Course_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        ExamQuestion_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExamQuestions", t => t.ExamQuestion_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.ExamQuestion_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.ExamQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionNumber = c.Int(nullable: false),
                        Content = c.String(),
                        Exam_Id = c.Int(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.Exam_Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Exam_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                        level = c.String(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionNumber = c.Int(nullable: false),
                        Content = c.String(),
                        QuestionType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.QuestionTypes", t => t.QuestionType_Id)
                .Index(t => t.QuestionType_Id);
            
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Level = c.String(),
                        OpenAnswer = c.String(),
                        MultipleChoice = c.String(),
                        ClosedAnswer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        HiringDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Level = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Courses", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.Responses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Responses", "ExamQuestion_Id", "dbo.ExamQuestions");
            DropForeignKey("dbo.Questions", "QuestionType_Id", "dbo.QuestionTypes");
            DropForeignKey("dbo.ExamQuestions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.ExamQuestions", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.Exams", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Enrollments", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Questions", new[] { "QuestionType_Id" });
            DropIndex("dbo.Exams", new[] { "Course_Id" });
            DropIndex("dbo.ExamQuestions", new[] { "Question_Id" });
            DropIndex("dbo.ExamQuestions", new[] { "Exam_Id" });
            DropIndex("dbo.Responses", new[] { "Student_Id" });
            DropIndex("dbo.Responses", new[] { "ExamQuestion_Id" });
            DropIndex("dbo.Enrollments", new[] { "Student_Id" });
            DropIndex("dbo.Enrollments", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "Subject_Id" });
            DropIndex("dbo.Courses", new[] { "Professor_Id" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Professors");
            DropTable("dbo.QuestionTypes");
            DropTable("dbo.Questions");
            DropTable("dbo.Exams");
            DropTable("dbo.ExamQuestions");
            DropTable("dbo.Responses");
            DropTable("dbo.Students");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Courses");
        }
    }
}
