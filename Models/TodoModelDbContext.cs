using Microsoft.EntityFrameworkCore;

namespace Index.txt.Models
{
    public class TodoModelDbContext : DbContext
    {
        public TodoModelDbContext(DbContextOptions<TodoModelDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItemProject>().HasKey(sc => new {sc.TodoItemId, sc.ProjectId});
            modelBuilder.Entity<TodoItemContext>().HasKey(sc => new {sc.TodoItemId, sc.ContextId});
            modelBuilder.Entity<TodoItemKeyValue>().HasKey(sc => new {sc.TodoItemId, sc.KeyValueId});
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Context> Contexts { get; set; }
        public DbSet<KeyValue> KeyValues { get; set; }
        
        public DbSet<TodoItemProject> TodoItemProjects { get; set; }
        public DbSet<TodoItemContext> TodoItemContexts { get; set; }
        public DbSet<TodoItemKeyValue> TodoItemKeyValues { get; set; }
    }
}