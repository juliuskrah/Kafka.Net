using Microsoft.EntityFrameworkCore;
using Producer.Models;

namespace Producer.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext()
        { }

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        { }

        public DbSet<Todo> Todos { get; set; }
    }
}
