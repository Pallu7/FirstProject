using Microsoft.EntityFrameworkCore;

namespace FirstProject.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options):base ("DefaultConnection") { 
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null;
    }
}
