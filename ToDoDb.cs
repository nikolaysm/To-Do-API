using Microsoft.EntityFrameworkCore;

class ToDoDb : DbContext
{
    public ToDoDb(DbContextOptions<ToDoDb> options)
        : base(options) { }

  
  
    public DbSet<ToDo> ToDos => Set<ToDo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ToDo>()
            .HasData(
            new ToDo { Id = 1, TaskName = "Walk Dog", Completed = true },
            new ToDo { Id = 2, TaskName = "Clean Pool", Completed = false },
            new ToDo { Id = 3, TaskName = "Wash Car", Completed = true }
            );
    }
}