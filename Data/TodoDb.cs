using ApiMinima.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiMinima.Data
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options ) 
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
