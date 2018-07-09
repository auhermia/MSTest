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
        public int Id { get; set; }
        public Guid QuestionId { get; set; }
        public int QuestionNumber { get; set; }
    }
}