using Microsoft.EntityFrameworkCore;

namespace UsingAJAX.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
