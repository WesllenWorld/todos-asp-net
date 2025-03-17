using Microsoft.EntityFrameworkCore;
using TwTodos.Models;

namespace TwTodos.Contexts;

public class TwTodosContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todos.sqlite3");
    }
}
