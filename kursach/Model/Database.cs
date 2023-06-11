using Microsoft.EntityFrameworkCore;

namespace kursach
{
    public class ApplicationContext : DbContext
    {

        public partial class dbContext : DbContext
        {
            public dbContext()
            {
            }

            public dbContext(DbContextOptions<dbContext> options)
                : base(options)
            {
            }

            public virtual DbSet<User> Users { get; set; }
            public virtual DbSet<Zakaz> Zakaz { get; set; }
            public virtual DbSet<ManagerClass> Managers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Server=localhost;Database=Users;Trusted_Connection=True;TrustServerCertificate=True;");
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }

}

