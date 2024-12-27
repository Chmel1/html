using Microsoft.EntityFrameworkCore;

namespace Exam.DB
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<DB.User> Users { get; set; } = null!;
        public DbSet<DB.Products> Products { get; set; } = null!;
        public DbSet<DB.Orders> Orders { get; set; } = null!;
        public DbSet<DB.DataFixtures> DataFixtures { get; set; } = null!;
        public DbSet<DB.Clients> Clients { get; set; } = null!;

        public DbSet<DB.OrdersDetails> OrdersDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Host = "80.76.107.163";
            int Port = 65432;
            string Database = "exam-var-" + Program.VariantNumber.ToString();
            string UserName = "exam";
            string Password = "UWL0R2XRO3";

            optionsBuilder.UseNpgsql($"Host={Host};Port={Port.ToString()};Database={Database};Username={UserName};Password={Password}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // вызываем один раз

            // Конфигурация для перечисления OrderStatus
            modelBuilder.Entity<DB.Orders>()
                .Property(o => o.Status)
                .HasConversion<int>(); // Сохраняем как целое число в базе данных

            // Если вы хотите игнорировать свойство Status, уберите строку выше
            // modelBuilder.Entity<DB.Orders>().Ignore(o => o.Status);

            // Конфигурация для DataFixtures
            modelBuilder.Entity<DataFixtures>()
                .HasNoKey();
        }
    }
}
