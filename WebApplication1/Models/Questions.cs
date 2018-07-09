using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        public Guid QuestionId { get; set; }
        public Guid SurveyId { get; set; }
        public Guid ParentId { get; set; }
        public int QuestionNumber { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        [Display(Name ="Answer Type")]
        public string AnswerType { get; set; }
        public int SortOrder { get; set; }

        // format, backcolor, sortorder, cratedby, craetedon
        // closedbyansweroptionid
    }
}