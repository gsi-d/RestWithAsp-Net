using Microsoft.EntityFrameworkCore;

namespace ResWithASP_Net.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Book> Book { get; set; }

    }
}
