using BWACheckLogNoAuth.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Recipe> tblRecipe { get; set; }

        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<UserResponse> UserResponses { get; set; }
        public DbSet<ResponseDetail> ResponseDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Recipe>().HasKey(p => p.RecipeId);
            builder.Entity<Recipe>().Property(p => p.RecipeId).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
