using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string password = Environment.GetEnvironmentVariable("B1ADMIN_DB_PASSWORD");

            string connectionString =
                $"server=localhost;database=empresa;user=b1admin;password={password};";

            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );
        }
    }
}
