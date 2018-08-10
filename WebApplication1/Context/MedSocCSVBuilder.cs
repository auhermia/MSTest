using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MedSocCSVBuilder.Models;

namespace MedSocCSVBuilder.Context
{
    public class MedSocCSVBuilderContext : DbContext
    {
        public class MedSocCSVBuilder
        {
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
    
}