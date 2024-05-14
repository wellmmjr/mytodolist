using Microsoft.EntityFrameworkCore;

namespace mytodolist.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<ListaTarefa> Listas { get; set; }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
