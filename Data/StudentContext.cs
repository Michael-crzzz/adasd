using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;
using WebApplication1.Models.EventEntity;

namespace WebApplication1.Data
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options): base(options)
        {
        }

        public DbSet<BStudent> BSutends { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}
