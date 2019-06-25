using Index.txt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Index.txt.Data
{
    public class TodoModelDbContext : IdentityDbContext
    {
        public TodoModelDbContext(DbContextOptions<TodoModelDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItemProject>().HasKey(sc => new {sc.TodoItemId, sc.ProjectId});
            modelBuilder.Entity<TodoItemContext>().HasKey(sc => new {sc.TodoItemId, sc.ContextId});
            modelBuilder.Entity<KeyValue>()
                .HasOne(e => e.TodoItem)
                .WithMany(c => c.KeyValues)
                .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Context> Contexts { get; set; }
        public DbSet<KeyValue> KeyValues { get; set; }
        
        public DbSet<TodoItemProject> TodoItemProjects { get; set; }
        public DbSet<TodoItemContext> TodoItemContexts { get; set; }
    }
}