using Microsoft.EntityFrameworkCore;

namespace HubSpotAuth.Models
{
    public class ContactsDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ContactsDbContext(DbContextOptions<ContactsDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Contact entity
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(c => c.LastName).IsRequired().HasMaxLength(50);
                entity.Property(c => c.Email).IsRequired().HasMaxLength(100);
            });
        }
    }

}
