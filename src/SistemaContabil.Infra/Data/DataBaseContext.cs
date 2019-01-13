using Microsoft.EntityFrameworkCore;
using SistemaContabil.Infra.Data.Mapping;

namespace SistemaContabil.Infra.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NotaFiscalMap());
        }
    }
}
