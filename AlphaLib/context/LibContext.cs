using Microsoft.EntityFrameworkCore;

namespace AlphaLib
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Users> TodoItems { get; set; }
    }
}