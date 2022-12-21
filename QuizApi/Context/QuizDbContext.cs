using Microsoft.EntityFrameworkCore;
using QuizApi.Models;

namespace QuizApi.Context
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)   
        {

        }

        public DbSet<Question>  Quetions { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
