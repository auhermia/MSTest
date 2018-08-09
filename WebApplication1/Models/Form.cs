using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Form
    {
        [Key]
        public int SurveyId { get; set; }
        [Required]
        public string SurveyName { get; set; }
    }
}