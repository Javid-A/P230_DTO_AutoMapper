using Microsoft.EntityFrameworkCore;
using P230DTO.Entities;
using P230DTO.Entities_Configurations;

namespace P230DTO.DAL
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Address> Addresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API (Burdaki API sozunun hal hazirda kecdiyimiz API ile bir elaqesi yoxdur. MVC proyektlerinde de bunu tetbiq ede bilersiniz)

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Address)
            //    .WithOne(a => a.Employee)
            //    .HasForeignKey<Address>(a=>a.EmployeeId);
            modelBuilder.ApplyConfiguration(new BookConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
