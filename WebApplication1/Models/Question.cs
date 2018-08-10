using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedSocCSVBuilder.Models
{
    public class Question
    {
        [Key]
        public Guid QuestionId { get; set; }
        public Guid SurveyId { get; set; }
        public Guid ParentId { get; set; }
        [Display(Name = "Question Number")]
        public int QuestionNumber { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        [Display(Name ="Answer Type")]
        public string AnswerType { get; set; }
        public int SortOrder { get; set; }
        public Guid ClosedByAnswerOptionId { get; set; }

        public string Format { get; set; }
        public string BackColor { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }

        public virtual Form Form { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}