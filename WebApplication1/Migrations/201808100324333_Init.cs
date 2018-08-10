namespace MedSocCSVBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerId = c.Guid(nullable: false),
                        QuestionId = c.Guid(nullable: false),
                        AnswerText = c.String(),
                        SortOrder = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedOn = c.String(),
                    })
                .PrimaryKey(t => t.AnswerId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Guid(nullable: false),
                        SurveyId = c.Guid(nullable: false),
                        ParentId = c.Guid(nullable: false),
                        QuestionNumber = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                        AnswerType = c.String(nullable: false),
                        SortOrder = c.Int(nullable: false),
                        ClosedByAnswerOptionId = c.Guid(nullable: false),
                        Format = c.String(),
                        BackColor = c.String(),
                        CreatedBy = c.String(),
                        CreatedOn = c.String(),
                        Form_SurveyId = c.Int(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Forms", t => t.Form_SurveyId)
                .Index(t => t.Form_SurveyId);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        SurveyName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyId);
            
            CreateTable(
                "dbo.QuestionAnswers",
                c => new
                    {
                        Question_QuestionId = c.Guid(nullable: false),
                        Answer_AnswerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Question_QuestionId, t.Answer_AnswerId })
                .ForeignKey("dbo.Questions", t => t.Question_QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Answers", t => t.Answer_AnswerId, cascadeDelete: true)
                .Index(t => t.Question_QuestionId)
                .Index(t => t.Answer_AnswerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Form_SurveyId", "dbo.Forms");
            DropForeignKey("dbo.QuestionAnswers", "Answer_AnswerId", "dbo.Answers");
            DropForeignKey("dbo.QuestionAnswers", "Question_QuestionId", "dbo.Questions");
            DropIndex("dbo.QuestionAnswers", new[] { "Answer_AnswerId" });
            DropIndex("dbo.QuestionAnswers", new[] { "Question_QuestionId" });
            DropIndex("dbo.Questions", new[] { "Form_SurveyId" });
            DropTable("dbo.QuestionAnswers");
            DropTable("dbo.Forms");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
