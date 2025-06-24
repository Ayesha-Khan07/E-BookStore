using Microsoft.EntityFrameworkCore;

namespace _2ndBookStore
{
    public class StoreContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public virtual DbSet<OnlinePay> OnlinePays { get; set; }
        public DbSet<StoreAdmin> StoreAdmins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(u => u.Email);

            /*
              ------ if there is no primary key of table------
                modelBuilder.Entity<Cash>()
                .HasNoKey();
            */

        }
      
       

        

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
