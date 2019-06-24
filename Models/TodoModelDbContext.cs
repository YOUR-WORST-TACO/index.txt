using Microsoft.EntityFrameworkCore;

namespace Index.txt.Models
{
    public class TodoModelDbContext : DbContext
    {
        public TodoModelDbContext(DbContextOptions<TodoModelDbContext> options) : base(options)
        {}

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Context> Contexts { get; set; }
        public DbSet<KeyValue> KeyValues { get; set; }
    }
}