using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedSocCSVBuilder.Models
{
    public class Answer
    {
        [Key]
        public Guid AnswerId { get; set; }
        public Guid QuestionId { get; set; }
        public string AnswerText { get; set; }

        public int SortOrder { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

    }
}