using Microsoft.EntityFrameworkCore;

namespace DataAcess.Model
{
    public partial class PowerPlantContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PowerPlantContext()
        {
        }
        public PowerPlantContext(DbContextOptions<PowerPlantContext> options)
      : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
