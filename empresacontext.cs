using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=empresa;user=root;password=B1Admin;",
                ServerVersion.AutoDetect("server=localhost;database=empresa;user=root;password=B1Admin;")
            );
        }
    }
}
