using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Answers
    {
        [Key]
        public Guid AnswerId { get; set; }
        public Guid QuestionId { get; set; }
        public string AnswerText { get; set; }

        // auto-generated
        public int SortOrder { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        
    }
}