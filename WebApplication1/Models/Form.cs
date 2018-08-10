using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MedSocCSVBuilder.Models
{
    public class Form
    {
        [Key]
        public int SurveyId { get; set; }
        [Required]
        public string SurveyName { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}