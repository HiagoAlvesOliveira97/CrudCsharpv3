using Microsoft.EntityFrameworkCore;

namespace CrudCsharpv3.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-CM8F2OC\SQLEXPRESS;Database=Crudv3; Integrated Security=True");
        }
    }
}
